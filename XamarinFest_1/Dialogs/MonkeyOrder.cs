using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFest_1.Dialogs
{
    public enum Contact
    {
        Twitter,
        Facebook,
        LinkedIn,
        [Describe("Un amigo me dijo")]
        [Terms("Un amigo me dijo")]
        AFriendToldMe
    }

    public enum Role
    {
        [Describe("Desarrollador")]
        [Terms("Desarrollador")]
        Developer,
        [Terms("Estudiante")]
        [Describe("Estudiante")]
        Student,
        [Terms("Diseñador")]
        [Describe("Diseñador")]
        Designer,
        [Terms("PM")]
        [Describe("PM")]
        ProjectManager,
        [Terms("Otro")]
        [Describe("Otro")]
        Other
    }

    [Serializable]
    public class MonkeyOrder
    {
        [Describe("Nombre")]
        [Prompt("Ingrese su nombre")]
        public string Name { get; set; }
        [Describe("Apellido")]
        [Prompt("Ingrese su apellido")]
        public string LastName { get; set; }
        [Describe("Fecha de nacimiento")]
        [Prompt("Ingrese su fecha de nacimiento")]
        public DateTime? DateOfBirth { get; set; }
        [Describe("Empresa")]
        [Prompt("Ingrese su empresa")]
        public string Company { get; set; }
        [Describe("Rol")]
        [Terms("Rol")]
        public Role? Role { get; set; }
        [Describe("como se enteró del evento")]
        public Contact? Contact { get; set; }
        [Describe("Impresiones")]
        [Prompt("Qué le pareció el evento?")]
        public string Impressions { get; set; }

        public static IForm<MonkeyOrder> BuildForm()
        {
            return new FormBuilder<MonkeyOrder>()
                    .Message("Hola! Bienvenido al bot del Xamarin Fest! Ingresá tus datos si querés participar del sorteo de regalos!")
                    .Build();
        }
    }
}