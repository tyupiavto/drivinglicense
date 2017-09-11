using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrivingLicense.Models;
using DrivingLicense.Infrastrucure;
using System.Drawing;
using DrivingLicense.Infrastructure;

namespace DrivingLicense.Controllers
{
    public class ExamController : Controller
    {
        public static DrivingLicenseDataDataContext db = new DrivingLicenseDataDataContext();
        public static List<int> FullTicketMessed = new List<int>(); // srulad randomit areuli biletebi 
        public static List<int> OneTicketMessed = new List<int>(); // erti biletistvis areuli masivi
        public static List<Point> ErrorResultShow = new List<Point>(); // mcdari pasuxebis chveneba
        public static List<int> CorrectResultShow = new List<int>(); // swori pasuxebis chveneba
        public static List<DrivingLicenseData> SelectedCategoriesTickets = new List<DrivingLicenseData>();
        public static List<int> ResultTopics = new List<int>();
        public AnswerMix mix = new AnswerMix();
        static int LenghtCounter = 0, Counter = 0, FullLenght = 0, AddTicket = 0, ind = 0, Calculate=0,TicketCount=30, TicketLenght=0;
        //
        // GET: /Home/
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Exam()
        {
            FullTicketMessed.Clear();
            OneTicketMessed.Clear();
            CorrectResultShow.Clear();
            ErrorResultShow.Clear();
            LenghtCounter = 0;
            FullLenght = 0;
            AddTicket = 0;
            Calculate = 0;
            ind = 0;
            return View();
        }
        [HttpPost]
        public ActionResult QuestionsTopics(List<int> ResultTopics)
        {
            SelectedCategoriesTickets = db.DrivingLicenseDatas.Where(x => ResultTopics.Contains(x.SteppeNumber)).ToList();

            if (SelectedCategoriesTickets.Count >= TicketCount)
            {
                TicketLenght = TicketCount;
            }
            else
            {
                TicketLenght = SelectedCategoriesTickets.Count;
            }
            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult StartPageLoad(List<int> ResultTopics, string answer, string ticketSkip, string sameTicket, string newTicket, string CorrectAnswers, string WrongAnswers, string CorrectWrongClose, string CorrectItem, string indcount, string count)
        {
            if (CorrectAnswers != "true" && WrongAnswers!="true")
            {
                if (Calculate == 0)
                {
                    Calculate = 1;

                    AddTicket = TicketCount - (SelectedCategoriesTickets.Count - (SelectedCategoriesTickets.Count / TicketCount) * TicketCount);
                    if (AddTicket != TicketCount && SelectedCategoriesTickets.Count > TicketCount)
                    {
                        new RandomMessed(0, TicketCount - 1, OneTicketMessed);

                        for (int i = 0; i < AddTicket; i++)
                        {
                            SelectedCategoriesTickets.Add(SelectedCategoriesTickets[OneTicketMessed[i]]);
                        }
                        OneTicketMessed.Clear();
                    }
                    new RandomMessed(0, SelectedCategoriesTickets.Count - 1, FullTicketMessed);

                    if (SelectedCategoriesTickets.Count > TicketCount)
                    {
                        TicketCount = 30;
                        OneTicketMessed.Clear();
                        new RandomMessed(0, TicketCount - 1, OneTicketMessed);
                    }
                    else
                    {
                        OneTicketMessed.Clear();
                        new RandomMessed(0, SelectedCategoriesTickets.Count - 1, OneTicketMessed);
                        TicketCount = SelectedCategoriesTickets.Count;
                    }
                    mix.AnswerMi(TicketLenght, SelectedCategoriesTickets, FullTicketMessed, OneTicketMessed);
                }
                if (sameTicket == "true")
                {
                    CorrectResultShow.Clear();
                    ErrorResultShow.Clear();
                    OneTicketMessed.Clear();
                    if (SelectedCategoriesTickets.Count < TicketCount)
                    {
                        new RandomMessed(0, SelectedCategoriesTickets.Count - 1, OneTicketMessed);
                    }
                    else
                    {
                        if (LenghtCounter != TicketCount)
                        {
                            new RandomMessed(FullLenght - LenghtCounter, FullLenght + TicketCount - 1, OneTicketMessed);
                        }
                        else
                        {
                            new RandomMessed(FullLenght - TicketCount, FullLenght - 1, OneTicketMessed);
                        }
                    }
                    LenghtCounter = 0;
                    FullLenght -= TicketCount;
                    ind = 0;
                    mix.AnswerMi(TicketLenght, SelectedCategoriesTickets, FullTicketMessed, OneTicketMessed);
                }

                if (newTicket == "true" && SelectedCategoriesTickets.Count >= 30)
                {
                    CorrectResultShow.Clear();
                    ErrorResultShow.Clear();
                    OneTicketMessed.Clear();
                    new RandomMessed(FullLenght, FullLenght + TicketCount - 1, OneTicketMessed);
                    LenghtCounter = 0;
                    ind = 0;
                    mix.AnswerMi(TicketLenght, SelectedCategoriesTickets, FullTicketMessed, OneTicketMessed);
                }
                //if (ticketSkip == "true")
                //{
                //    OneTicketMessed.Add(OneTicketMessed[LenghtCounter]);
                //    OneTicketMessed.RemoveAt(LenghtCounter);
                //    ind = 0;
                //}
                if (answer!=null && answer == SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[LenghtCounter]]].CorrectAnswer.ToString())
                {
                    CorrectResultShow.Add(FullTicketMessed[OneTicketMessed[LenghtCounter]]); // swori pasuxis damaxsovreba
                }
                if ( answer != null && answer != "" && answer != SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[LenghtCounter]]].CorrectAnswer.ToString())
                {
                    ErrorResultShow.Add(new Point(FullTicketMessed[OneTicketMessed[LenghtCounter]], Convert.ToInt32(answer))); // araswori pasuxis damaxsovreba
                }
                if (ind != 0 && CorrectWrongClose!="true")
                {
                    LenghtCounter++;
                    FullLenght++;
                }
                ind = 1;

                if (LenghtCounter == OneTicketMessed.Count)
                {
                    return Json(new { Dataresult = SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[LenghtCounter - 1]]], testEnd = LenghtCounter, questionsQuantity = FullLenght, ticketLenght = TicketLenght }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { Dataresult = SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[LenghtCounter]]], testEnd = LenghtCounter, questionsQuantity = FullLenght, ticketLenght = TicketLenght }, JsonRequestBehavior.AllowGet);
                }

            }
            else
            {
                if (count == "0")
                {
                    if (indcount == "0")
                    {
                        indcount = "1";
                        CorrectItem = Convert.ToString((CorrectResultShow.Count) - 1);
                    }
                    return Json(new { Dataresult = SelectedCategoriesTickets[CorrectResultShow[Convert.ToInt32(CorrectItem)]], testErr = CorrectResultShow.Count }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    if (indcount == "0")
                    {
                        indcount = "1";
                        CorrectItem = Convert.ToString((ErrorResultShow.Count) - 1);
                    }
                    return Json(new { Dataresult = SelectedCategoriesTickets[ErrorResultShow[Convert.ToInt32(CorrectItem)].X], testErr = ErrorResultShow.Count, error = ErrorResultShow[Convert.ToInt32(CorrectItem)].Y }, JsonRequestBehavior.AllowGet);
                }
            }
        }
        public ActionResult HomePage()
        {
            return View();
        }
}
}