using System.Text;
using TASK5.Command;
using TASK5.State;

namespace TASK5
{
    enum DisplayType { Block, Inline }
    enum ClosingType { SelfClosing, WithClosingTag }

    class Program
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
                ("1", "Олена Коваль",   "Математика",  "97"),
                ("2", "Тарас Бойко",    "Фізика",      "84"),
                ("3", "Марія Шевченко", "Інформатика", "91"),
                ("4", "Іван Мельник",   "Хімія",       "78"),
            };

            foreach (var (num, name, subject, grade) in rows)
            {
                var tr = new LightElementNode("tr");
                foreach (var cell in new[] { num, name, subject, grade })
                    tr.Add(new LightElementNode("td", DisplayType.Inline).AddText(cell));
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
            try { img.AddText("текст"); }
            catch (InvalidOperationException ex) { Console.WriteLine($"Помилка: {ex.Message}"); }

            Console.WriteLine("\n\n=== PR #1: Template Method — lifecycle hooks ===");

            var div = new LightElementNode("div", DisplayType.Block,
                          ClosingType.WithClosingTag, new[] { "card" });
            div.LogLifecycle = true;

            Console.WriteLine("\n-- Додаємо дочірній елемент --");
            var span = new LightElementNode("span", DisplayType.Inline) { LogLifecycle = true };
            span.AddText("Привіт");
            div.Add(span);

            Console.WriteLine("\n-- Викликаємо Render() --");
            string result = div.Render();
            Console.WriteLine(result);

            Console.WriteLine("-- Видаляємо дочірній елемент --");
            div.Remove(span);
            Console.WriteLine("\n\n=== Iterator — обхід дерева ===");

            var html = new LightElementNode("html");
            var body = new LightElementNode("body");
            var h1 = new LightElementNode("h1").AddText("Заголовок");
            var ul = new LightElementNode("ul");
            ul.Add(new LightElementNode("li").AddText("Пункт 1"));
            ul.Add(new LightElementNode("li").AddText("Пункт 2"));
            body.Add(h1).Add(ul);
            html.Add(body);

            Console.Write("\nDFS: ");
            foreach (var node in new LightNodeCollection(html, depthFirst: true))
                if (node is LightElementNode e) Console.Write($"<{e.TagName}> ");

            Console.Write("\nBFS: ");
            foreach (var node in new LightNodeCollection(html, depthFirst: false))
                if (node is LightElementNode e) Console.Write($"<{e.TagName}> ");

            Console.WriteLine();
            Console.WriteLine("\n\n=== Command — undo/redo ===");

            var history = new CommandHistory();
            var list = new LightElementNode("ul");
            var newLi = new LightElementNode("li").AddText("Новий пункт");

            Console.WriteLine($"Дітей до додавання: {list.ChildCount}");

            history.Execute(new AddChildCommand(list, newLi));
            Console.WriteLine($"Після Execute:      {list.ChildCount}");

            history.Undo();
            Console.WriteLine($"Після Undo:         {list.ChildCount}");

            history.Redo();
            Console.WriteLine($"Після Redo:         {list.ChildCount}");

            history.Execute(new AddCssClassCommand(list, "highlighted"));
            Console.WriteLine($"CSS класи: {string.Join(", ", list.CssClasses)}");

            history.Undo();
            Console.WriteLine($"Після Undo CSS: {string.Join(", ", list.CssClasses)}");
            Console.WriteLine("\n\n=== State — стани елемента ===");

            var btn = new LightElementNode("button", DisplayType.Inline);
            Console.WriteLine(btn.GetStateInfo());

            btn.SetState(new HoveredState());
            Console.WriteLine(btn.GetStateInfo());

            btn.SetState(new DisabledState());
            Console.WriteLine(btn.GetStateInfo());

            btn.SetState(new IdleState());
            Console.WriteLine(btn.GetStateInfo());
        }
    }
}