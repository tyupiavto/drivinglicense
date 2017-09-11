using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrivingLicense.Models;
using DrivingLicense.Infrastrucure;
using System.Drawing;

namespace DrivingLicense.Infrastructure
{
 
    public class AnswerMix
    {
        public List<string> answer = new List<string>(3);
        public List<int> mix = new List<int>();
        public List<DrivingLicenseData> AnswerMi (int TicketLenght , List<DrivingLicenseData> SelectedCategoriesTickets, List<int> FullTicketMessed,List<int> OneTicketMessed)
        {
            for (int i=0; i<TicketLenght; i++)
            {
                answer.Add ( SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerOne);
                answer.Add(SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerTwo);
                answer.Add (SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerThree);
                answer.Add(SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerFour);

                new RandomMessed(0, SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswersPoints-1,mix);
                for (int j = 0; j < SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswersPoints; j++)
                {
                    if (SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].CorrectAnswer==mix[j]+1)
                    {
                        SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].CorrectAnswer = j + 1;
                        break;
                    }
                }
                SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerOne = answer[mix[0]];
                SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerTwo = answer[mix[1]];
                if (mix.Count >= 3)
                {
                    SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerThree = answer[mix[2]];
                }
                if (mix.Count == 4)
                {
                    SelectedCategoriesTickets[FullTicketMessed[OneTicketMessed[i]]].AnswerFour = answer[mix[3]];
                }
                answer.Clear();
                mix.Clear();
            }
            return (SelectedCategoriesTickets);
        }
    }
}