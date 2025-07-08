using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Bitsplash.DatePicker
{
    /// <summary>
    /// This is a UI.Text or TextMeshProUGUI implementation of the dropdown
    /// </summary>
    public class DatePickerDropDown : DatePickerDropDownBase
    {
        public Text LabelText;
        public TextMeshProUGUI LabelTMP;

        protected override void SetText(string text)
        {
            if (LabelText != null)
                LabelText.text = text;
            else if (LabelTMP != null)
                LabelTMP.text = text;
        }
    }
}
