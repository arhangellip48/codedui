namespace CodedUITestProject12
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// mtr - Используйте "mtrParams" для передачи параметров в этот метод.
        /// </summary>
        public void mtr()
        {
            #region Variable Declarations
            WinComboBox uI_beginDateComboBox = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UI_beginDateWindow.UI_beginDateComboBox;
            WinComboBox uI_endDateComboBox = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UI_endDateWindow.UI_endDateComboBox;
            WinEdit uI_beginDateEdit = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIItemComboBox.UI_beginDateEdit;
            WinEdit uI_endDateEdit = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIItemComboBox1.UI_endDateEdit;
            #endregion

            // Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_beginDate" поле со списком
            Keyboard.SendKeys(uI_beginDateComboBox, this.mtrParams.UI_beginDateComboBoxSendKeys, ModifierKeys.None);

            // Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_endDate" поле со списком
            Keyboard.SendKeys(uI_endDateComboBox, this.mtrParams.UI_endDateComboBoxSendKeys, ModifierKeys.None);

            Keyboard.SendKeys(uI_beginDateComboBox, "01.06.2018");

            // Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_endDate" поле со списком
            Keyboard.SendKeys(uI_endDateComboBox, "07.06.2018");
        }

        public virtual mtrParams mtrParams
        {
            get
            {
                if ((this.mmtrParams == null))
                {
                    this.mmtrParams = new mtrParams();
                }
                return this.mmtrParams;
            }
        }

        private mtrParams mmtrParams;

        /// <summary>
        /// RecordedMethod1 - Используйте "RecordedMethod1Params" для передачи параметров в этот метод.
        /// </summary>

        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        private RecordedMethod1Params mRecordedMethod1Params;

        /// <summary>
        /// RecordedMethod333 - Используйте "RecordedMethod333Params" для передачи параметров в этот метод.
        /// </summary>
        public void RecordedMethod333()
        {
            #region Variable Declarations
            WinComboBox uIПопривязкепациентовкComboBox = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIПопривязкепациентовкWindow.UIПопривязкепациентовкComboBox;
            WinEdit uIFilterCombo_EmbeddabEdit = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIFilterCombo_EmbeddabWindow.UIFilterCombo_EmbeddabEdit;
            WinComboBox uIВсеComboBox = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIВсеWindow.UIВсеComboBox;
            WinEdit uI_conditionCombo_EmbeEdit = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UI_conditionCombo_EmbeWindow.UI_conditionCombo_EmbeEdit;
            WinComboBox uIТолькопрошедшиеComboBox = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIВсеWindow.UIТолькопрошедшиеComboBox;
            WinEdit uI_conditionCombo_EmbeEdit1 = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UI_conditionCombo_EmbeWindow.UI_conditionCombo_EmbeEdit1;
            WinButton uIПолучитьданныеButton = this.UIКвазарЖурналфлюорогрWindow.UIЖурналфлюорографичесWindow.UIПолучитьданныеWindow.UIПолучитьданныеButton;
            #endregion



            Keyboard.SendKeys(uIПопривязкепациентовкComboBox, "{Down}");
            Keyboard.SendKeys(uIВсеComboBox, "{Down}");



            // Щелкните "Получить данные" кнопка
            Mouse.Click(uIПолучитьданныеButton, new Point(71, 19));
        }

        public virtual RecordedMethod333Params RecordedMethod333Params
        {
            get
            {
                if ((this.mRecordedMethod333Params == null))
                {
                    this.mRecordedMethod333Params = new RecordedMethod333Params();
                }
                return this.mRecordedMethod333Params;
            }
        }

        private RecordedMethod333Params mRecordedMethod333Params;

        /// <summary>
        /// start - Используйте "startParams" для передачи параметров в этот метод.
        /// </summary>
        public void start()
        {
            #region Variable Declarations
            WinCustom uIItemCustom = this.UIItemWindow.UI_userNameWindow.UIItemCustom;
            WinEdit uI_userName_EmbeddableEdit = this.UIItemWindow.UI_userName_EmbeddableWindow.UI_userName_EmbeddableEdit;
            WinCustom uIItemCustom1 = this.UIItemWindow.UI_passwordWindow.UIItemCustom;
            WinEdit uI_password_EmbeddableEdit = this.UIItemWindow.UI_password_EmbeddableWindow.UI_password_EmbeddableEdit;
            WinButton uIВойтиButton = this.UIItemWindow.UIВойтиWindow.UIВойтиButton;
            WinButton uIЖурналыButton = this.UIКвазарЖурналфлюорогрWindow.UI_pluginContainerWindow.UIЖурналыButton;
            WinButton uISplitterBarButton = this.UIКвазарЖурналфлюорогрWindow.UI_pluginContainerWindow.UISplitterBarButton;
            WinButton uIСистемаправButton = this.UIКвазарЖурналфлюорогрWindow.UI_pluginContainerWindow.UIСистемаправButton;
            WinButton uIОбследованияButton = this.UIКвазарЖурналфлюорогрWindow.UIMedSoftRegistriesWindow.UIОбследованияButton;
            #endregion

            // Запуск "%ProgramFiles%\ООО МедСофт\Квазар\MedSoft.Start.exe"
            ApplicationUnderTest uIItemWindow = ApplicationUnderTest.Launch(this.startParams.UIItemWindowExePath, this.startParams.UIItemWindowAlternateExePath);

            // Щелкните пользовательский элемент управления
            Mouse.Click(uIItemCustom, new Point(116, 12));

            // Тип "" в "_userName_EmbeddableTextBox" надпись
            uI_userName_EmbeddableEdit.Text = this.startParams.UI_userName_EmbeddableEditText;

            // Щелкните "_userName_EmbeddableTextBox" надпись
            Mouse.Click(uI_userName_EmbeddableEdit, new Point(134, 9));

            // Тип "Лушкин медсофт" в "_userName_EmbeddableTextBox" надпись
            uI_userName_EmbeddableEdit.Text = this.startParams.UI_userName_EmbeddableEditText1;

            // Щелкните пользовательский элемент управления
            Mouse.Click(uIItemCustom1, new Point(18, 15));

            // Тип "********" в "_password_EmbeddableTextBox" надпись
            Keyboard.SendKeys(uI_password_EmbeddableEdit, this.startParams.UI_password_EmbeddableEditSendKeys, true);

            // Щелкните "Войти" кнопка
            Mouse.Click(uIВойтиButton, new Point(32, 9));

            // Щелкните "Журналы" кнопка
            Mouse.Click(uIЖурналыButton, new Point(27, 12));

            // Перемещение  "Splitter Bar" кнопка в "Система прав" кнопка
            
            uISplitterBarButton.EnsureClickable(new Point(uISplitterBarButton.Left, uISplitterBarButton.Top));
            Mouse.StartDragging(null, new Point(116, 185));//,  MouseButtons.Left);
            //Mouse.StartDragging(null, new Point(103, 300));
            Mouse.StopDragging(null, new Point(116, 670));
            // Щелкните "Обследования" кнопка
            Mouse.Click(uIОбследованияButton, new Point(110, 20));
        }

        public virtual startParams startParams
        {
            get
            {
                if ((this.mstartParams == null))
                {
                    this.mstartParams = new startParams();
                }
                return this.mstartParams;
            }
        }

        private startParams mstartParams;
    }
    /// <summary>
    /// Параметры для передачи в "mtr"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "15.0.26208.0")]
    public class mtrParams
    {

        #region Fields
        /// <summary>
        /// Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_beginDate" поле со списком
        /// </summary>
        public string UI_beginDateComboBoxSendKeys = "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Ba" +
            "ck}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}";

        /// <summary>
        /// Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_endDate" поле со списком
        /// </summary>
        public string UI_endDateComboBoxSendKeys = "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Ba" +
            "ck}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}";
        #endregion
    }
    /// <summary>
    /// Параметры для передачи в "RecordedMethod1"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "15.0.26208.0")]
    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_beginDate" поле со списком
        /// </summary>
        public string UI_beginDateComboBoxSendKeys = @"{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}";

        /// <summary>
        /// Тип "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}" в "_endDate" поле со списком
        /// </summary>
        public string UI_endDateComboBoxSendKeys = "{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Ba" +
            "ck}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back" +
            "}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}";
        #endregion
    }
    /// <summary>
    /// Параметры для передачи в "RecordedMethod333"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "15.0.26208.0")]
    public class RecordedMethod333Params
    {

        #region Fields
        /// <summary>
        /// Выберите "По привязке пациентов к медицинским участкам" в "По привязке пациентов к медицинским участкам" поле со списком
        /// </summary>
        public string UIПопривязкепациентовкComboBoxSelectedItem = "По привязке пациентов к медицинским участкам";

        /// <summary>
        /// Тип "{Down}" в "filterCombo_EmbeddableTextBox" надпись
        /// </summary>
        public string UIFilterCombo_EmbeddabEditSendKeys = "{Down}";

        /// <summary>
        /// Выберите "Все" в "Все" поле со списком
        /// </summary>
        public string UIВсеComboBoxSelectedItem = "Все";

        /// <summary>
        /// Тип "{Down}" в "_conditionCombo_EmbeddableTextBox" надпись
        /// </summary>
        public string UI_conditionCombo_EmbeEditSendKeys = "{Down}";

        /// <summary>
        /// Выберите "Только прошедшие" в "Только прошедшие" поле со списком
        /// </summary>
        public string UIТолькопрошедшиеComboBoxSelectedItem = "Только прошедшие";

        /// <summary>
        /// Тип "{Enter}" в "_conditionCombo_EmbeddableTextBox" надпись
        /// </summary>
        public string UI_conditionCombo_EmbeEdit1SendKeys = "{Enter}";
        #endregion
    }
    /// <summary>
    /// Параметры для передачи в "start"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "15.0.26208.0")]
    public class startParams
    {

        #region Fields
        /// <summary>
        /// Запуск "%ProgramFiles%\ООО МедСофт\Квазар\MedSoft.Start.exe"
        /// </summary>
        public string UIItemWindowExePath = "C:\\Program Files (x86)\\ООО МедСофт\\Квазар\\MedSoft.Start.exe";

        /// <summary>
        /// Запуск "%ProgramFiles%\ООО МедСофт\Квазар\MedSoft.Start.exe"
        /// </summary>
        public string UIItemWindowAlternateExePath = "%ProgramFiles%\\ООО МедСофт\\Квазар\\MedSoft.Start.exe";

        /// <summary>
        /// Тип "" в "_userName_EmbeddableTextBox" надпись
        /// </summary>
        public string UI_userName_EmbeddableEditText = "";

        /// <summary>
        /// Тип "Лушкин медсофт" в "_userName_EmbeddableTextBox" надпись
        /// </summary>
        public string UI_userName_EmbeddableEditText1 = "Лушкин медсофт";

        /// <summary>
        /// Тип "********" в "_password_EmbeddableTextBox" надпись
        /// </summary>
        public string UI_password_EmbeddableEditSendKeys = "mOL/lXDUSd/hy7K5BZnJEA==";
        #endregion
    }
}
