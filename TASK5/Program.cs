using System.Text;

namespace TASK5
{
    enum DisplayType { Block, Inline }
    enum ClosingType { SelfClosing, WithClosingTag }
    internal class Program
    {
            static void Main()
            {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            var table = new LightElementNode("table", DisplayType.Block, ClosingType.WithClosingTag,
                                new[] { "students-table" });

                var thead = new LightElementNode("thead");
                var headerRow = new LightElementNode("tr");
                foreach (var col in new[] { "#", "Ім'я", "Предмет", "Оцінка" })
                {
                    headerRow.Add(
                        new LightElementNode("th", DisplayType.Inline, ClosingType.WithClosingTag,
                            new[] { "header-cell" })
                        .AddText(col));
                }
                thead.Add(headerRow);
                table.Add(thead);

                var tbody = new LightElementNode("tbody");
                var rows = new[]
                {
            ("1", "Олена Коваль",     "Математика",   "97"),
            ("2", "Тарас Бойко",      "Фізика",       "84"),
            ("3", "Марія Шевченко",   "Інформатика",  "91"),
            ("4", "Іван Мельник",     "Хімія",        "78"),
        };

                foreach (var (num, name, subject, grade) in rows)
                {
                    var tr = new LightElementNode("tr");
                    foreach (var cell in new[] { num, name, subject, grade })
                    {
                        tr.Add(
                            new LightElementNode("td", DisplayType.Inline)
                            .AddText(cell));
                    }
                    tbody.Add(tr);
                }
                table.Add(tbody);

                var img = new LightElementNode("img", DisplayType.Inline, ClosingType.SelfClosing,
                              new[] { "logo" });

                Console.WriteLine("=== outerHTML таблиці ===");
                Console.WriteLine(table.OuterHTML());

                Console.WriteLine("\n=== innerHTML <tbody> ===");
                Console.WriteLine(tbody.InnerHTML());

                Console.WriteLine($"\n=== Кількість дочірніх елементів <tbody>: {tbody.ChildCount} ===");

                Console.WriteLine("\n=== самозакривний тег <img/> ===");
                Console.WriteLine(img.OuterHTML());

                Console.WriteLine("\n=== Спроба додати дочірній вузол до <img/> ===");
                try
                {
                    img.AddText("текст");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
        }
    }
