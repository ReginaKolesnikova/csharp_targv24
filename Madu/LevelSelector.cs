﻿using csharp_targv24.Madu;
using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.Madu
{
    /* Класс Levels — отображает меню выбора уровня сложности */
    public class LevelSelector
    {
        public string[] Levels { get; set; }
        public int SelectedLevel { get; set; }

        // Конструктор
        public LevelSelector()
        {
            Levels = new string[] { "EASY", "MEDIUM", "HARD", "HELL" };
            SelectedLevel = 1; // значение по умолчанию
        }

        // Метод для выбора уровня
        public void Choose()
        {
            string title = FiggleFonts.Standard.Render("SELECT LEVEL\n");
            int choice = Keyboard.ChooseOption(title, Levels);
            if (choice == 0)
            {
                SelectedLevel = 0;  // если нажал ESC
            }
            else
            {
                SelectedLevel = choice;
            }
        }

        // Метод для получения названия выбранного уровня
        public string GetSelectedLevelName()
        {
            return Levels[SelectedLevel - 1];
        }
    }
}