using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Application.Files
{
    public class DocsModel
    {
        public IFormFile FileBody { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Get { get; set; }
        public decimal FileId { get; set; }
        public string LabelName;

        public List<DocsModel> DocsForForm()
        {
            List<DocsModel> docs = new List<DocsModel>()
            {
                //Документы ребенка
                new DocsModel { FileId = 11, LabelName = "Свидетельство о рождении - для детей не достигших 14 лет"},
                new DocsModel { FileId = 2,  LabelName = "Паспорт гражданина РФ (ребенка)" },
                new DocsModel { FileId = 34, LabelName = "Медицинская справка по форме № 070/У (все пункты медицинской справки должны быть заполнены)" },
                new DocsModel { FileId = 23, LabelName = "Свидетельство о регистрации по месту жительства в городе Сургуте или справка с места жительства в городе Сургуте" },
                new DocsModel { FileId = 39, LabelName = "Cправка, подтверждающая факт установления инвалидности" },
                new DocsModel { FileId = 42, LabelName = "Cправка врачебной комиссии, которая выдаётся медицинской организацией Ханты-Мансийского автономного округа – Югры, осуществляющей деятельность на территории муниципального образования городской округ город Сургут, где ребенок-инвалид состоит на диспансерном учете"},
                new DocsModel { FileId = 10, LabelName = "СНИЛС"},

                //Документ удостоверяющий личность родителя/законного представителя
                new DocsModel { FileId = 27, LabelName = "Паспорт гражданина РФ (законного представителя)"},
            
                //Документ подтверждающий полномочия законного представителя
                new DocsModel { FileId = 20, LabelName = "Паспорт гражданина РФ (представителя заявителя)"},
                new DocsModel { FileId = 22, LabelName = "Свидетельство о перемене имени (представитель)" },
                new DocsModel { FileId = 32, LabelName = "Нотариальная доверенность, подтверждающий полномочия представителя заявителя на осуществление действий от его имени" }

                //new DocsModel { FileId = 37, LabelName = "Cогласие на обработку персональных данных заявителя" },
                //new DocsModel { FileId = 38, LabelName = "Cогласие на обработку персональных данных ребенка" },
            };

            return docs;
        }

    }
}
