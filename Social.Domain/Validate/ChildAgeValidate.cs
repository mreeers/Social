using Social.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Social.Domain.Validate
{
    public class ChildAgeValidate : ValidationAttribute
    {
        public ChildAgeValidate()
        {
            ErrorMessage = "Услуга доступна для детей от 0 до 17 лет. Проверьте дату рождения.";
        }

        public override bool IsValid(object value)
        {
            DateTime bdate = (DateTime)value;
            DateTime now = DateTime.Today;

            int age = now.Year - bdate.Year;
            if (bdate > now.AddYears(-age)) age--;

            if (age >= 18)
                return false;
            else
                return true;
        }
    }
}
