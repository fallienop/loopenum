using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace may3task
{


    public enum Status : byte
    {
        None = 0,


        [Display(Name = "Aktif Kullanıcıları Listeler")]
        Active = 1,


        [Display(Name = "Pasif Kullanıcıları Listeler")]
        Passive,


        [Display(Name = "Silinmiş Kullanıcıları Listeler")]
        Deleted,


        [Display(Name = "Kaydını Dondurmuş Kullanıcıları Listeler")]
        Holiday
    }
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>();

            if (displayAttribute != null)
            {
                return displayAttribute.GetName();
            }
            else
            {
                return enumValue.ToString();
            }
        }
    }

}
