using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }



        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 111,
                Name = "太田",
                HireDate = DateTime.Now,
            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            //シリアル化
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(writer, employee);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }
        }

            private static void Exercise1_2(string outfile) {
                var emps = new Employee[] {
                    new Employee{
                        Id = 111,
                        Name = "太田",
                        HireDate = DateTime.Now,
                    },
                    new Employee {
                        Id = 111,
                        Name = "韮川",
                        HireDate = DateTime.Now,
                    }
                };

                var settings = new XmlWriterSettings {
                    Encoding = new System.Text.UTF8Encoding(false),
                    Indent = true,
                    IndentChars = " ",
                };

                //シリアル化
                using (var writer = XmlWriter.Create(outfile, settings)) {
                    var serializer = new DataContractSerializer(emps.GetType());
                    serializer.WriteObject(writer, emps);
                }
            }

            private static void Exercise1_3(string file) {
                using(XmlReader reader = XmlReader.Create(file)) {
                    var serializer = new DataContractSerializer(typeof(Employee[]));
                    var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var employees in emps) {
                        Console.WriteLine("[Id={0}, Name={1}, HireData={2}]",
                                  employees.Id, employees.Name, employees.HireDate);
                    }
                }
            }

            private static void Exercise1_4(string file) {
            
            var employees = new Employee[] {
                    new Employee{
                        Id = 111,
                        Name = "太田",
                        HireDate = DateTime.Now,
                    },
                    new Employee {
                        Id = 111,
                        Name = "韮川",
                        HireDate = DateTime.Now,
                    }
            };
            using (var stream = new FileStream(file, FileMode.Create,
                                                                FileAccess.Write)) {
                var options = new JsonSerializerOptions {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase, //キー名のカスタマイズ
                };
                
                JsonSerializer.Serialize(stream, employees, options);

                //string jsonString = JsonSerializer.Serialize(employees, options);
                //Console.WriteLine(jsonString);//画面を出力
            }
        }

    }
}
