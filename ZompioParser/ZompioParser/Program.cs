using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZompioParser.Contracts;

namespace ZompioParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ZompioForm form = new ZompioForm();
            form.id = "/Form/1234567890.ZompioForm#";
            form.FormSchema = new FormSchema();
            form.FormSchema.Id = "/FormType/0987654321.ZompioForm#";

            var firstName = new BaseField() {
                Title ="First Name" ,Description ="This is FirstName",
                Type  ="string",Required =true};
            form.FormSchema.Properties.Add("firstName", firstName);

            var lastName = new BaseField()
            {
                Title = "Last Name",
                Description = "This is Last Name",
                Type = "string",
                Required = true
            };
            form.FormSchema.Properties.Add("lastName", lastName);

            var age = new BaseField()
            {
                Title = "Last Name",
                Description = "This is Last Name",
                Type = "string",
                Required = true,
                EnumList = new List<string>() {"male","female","Other" }
            };
            form.FormSchema.Properties.Add("age", age);



            form.FormView = new FormView();

            form.FormView.Id = "/FormType/0987654321.ZompioForm##";
            form.FormView.FormLayout = "Default";
            form.FormView.rootElement = new ZompioLayout();
            form.FormView.rootElement.IsContainer = true;
            form.FormView.rootElement.ControlId = "mainRoot";
            form.FormView.rootElement.Type = "rootElement";
            form.FormView.rootElement.Children = new Dictionary<string, BaseControl>();

            var myControl1 = new BaseControl();
            myControl1.ControlId = "TextBox1";
            myControl1.IsContainer = false;
            myControl1.Type = "string";
            //myControl1.FieldRef = new FieldRef() {Ref = "#FormSchema/firstName"};
            myControl1.Ref = "#FormSchema/firstName";
            form.FormView.rootElement.Children.Add("myControl1",myControl1);







            string json = JsonConvert.SerializeObject(form,Formatting.Indented);

            Console.WriteLine(json);

            var deForm = JsonConvert.DeserializeObject<ZompioForm>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            
//deForm.FormView.rootElement.Children[0].

            Console.Read();

        }
    }
}
