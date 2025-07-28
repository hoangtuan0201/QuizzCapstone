using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QuizzAPP.Utils
{
    /// <summary>
    /// Utility class for applying Material Design theme and styling
    /// </summary>
    public static class MaterialTheme
    {
        // Material Design Color Palette - Minimalist Blue/Grey Theme
        public static readonly Color PrimaryColor = Color.FromArgb(33, 150, 243);      // Blue 500
        public static readonly Color PrimaryDarkColor = Color.FromArgb(21, 101, 192);  // Blue 700
        public static readonly Color PrimaryLightColor = Color.FromArgb(144, 202, 249); // Blue 200
        public static readonly Color AccentColor = Color.FromArgb(255, 193, 7);        // Amber 500
        public static readonly Color BackgroundColor = Color.FromArgb(250, 250, 250);  // Grey 50
        public static readonly Color SurfaceColor = Color.White;
        public static readonly Color ErrorColor = Color.FromArgb(244, 67, 54);         // Red 500
        public static readonly Color SuccessColor = Color.FromArgb(76, 175, 80);       // Green 500
        public static readonly Color WarningColor = Color.FromArgb(255, 152, 0);       // Orange 500
        
        // Text Colors
        public static readonly Color TextPrimaryColor = Color.FromArgb(33, 33, 33);    // Dark Grey
        public static readonly Color TextSecondaryColor = Color.FromArgb(117, 117, 117); // Medium Grey
        public static readonly Color TextHintColor = Color.FromArgb(158, 158, 158);     // Light Grey

        /// <summary>
        /// Initialize Material Design theme for the application
        /// </summary>
        /// <param name="materialSkinManager">MaterialSkinManager instance</param>
        public static void InitializeTheme(MaterialSkinManager materialSkinManager)
        {
            // Set the theme
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            
            // Set the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500,
                Primary.Blue700,
                Primary.Blue200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        /// <summary>
        /// Apply Material Design styling to a form
        /// </summary>
        /// <param name="form">Form to style</param>
        public static void ApplyFormStyling(Form form)
        {
            if (form is MaterialForm materialForm)
            {
                // Already a MaterialForm, just set properties
                materialForm.BackColor = BackgroundColor;
            }
            else
            {
                // Regular form styling
                form.BackColor = BackgroundColor;
                form.Font = new Font("Roboto", 10F, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Create a styled Material button
        /// </summary>
        /// <param name="text">Button text</param>
        /// <param name="isPrimary">Whether this is a primary button</param>
        /// <returns>Styled MaterialButton</returns>
        public static MaterialButton CreateButton(string text, bool isPrimary = true)
        {
            var button = new MaterialButton
            {
                Text = text,
                AutoSize = false,
                Height = 36,
                UseAccentColor = !isPrimary,
                Type = isPrimary ? MaterialButton.MaterialButtonType.Contained : MaterialButton.MaterialButtonType.Outlined,
                Density = MaterialButton.MaterialButtonDensity.Default
            };

            return button;
        }

        /// <summary>
        /// Create a styled Material text box
        /// </summary>
        /// <param name="hint">Hint text</param>
        /// <param name="isMultiline">Whether the textbox is multiline</param>
        /// <returns>Styled MaterialTextBox</returns>
        public static MaterialTextBox CreateTextBox(string hint, bool isMultiline = false)
        {
            var textBox = new MaterialTextBox
            {
                Hint = hint,
                Multiline = isMultiline,
                Height = isMultiline ? 100 : 48,
                Font = new Font("Roboto", 10F)
            };

            // Note: MaterialTextBox doesn't support ScrollBars property like regular TextBox

            return textBox;
        }

        /// <summary>
        /// Create a styled Material label
        /// </summary>
        /// <param name="text">Label text</param>
        /// <param name="fontSize">Font size</param>
        /// <param name="fontStyle">Font style</param>
        /// <returns>Styled MaterialLabel</returns>
        public static MaterialLabel CreateLabel(string text, float fontSize = 10F, FontStyle fontStyle = FontStyle.Regular)
        {
            return new MaterialLabel
            {
                Text = text,
                Font = new Font("Roboto", fontSize, fontStyle),
                ForeColor = TextPrimaryColor,
                AutoSize = true
            };
        }

        /// <summary>
        /// Create a styled Material card
        /// </summary>
        /// <returns>Styled MaterialCard</returns>
        public static MaterialCard CreateCard()
        {
            return new MaterialCard
            {
                BackColor = SurfaceColor,
                Padding = new Padding(16),
                Margin = new Padding(8)
            };
        }

        /// <summary>
        /// Create a styled Material radio button
        /// </summary>
        /// <param name="text">Radio button text</param>
        /// <returns>Styled MaterialRadioButton</returns>
        public static MaterialRadioButton CreateRadioButton(string text)
        {
            return new MaterialRadioButton
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Roboto", 10F)
            };
        }

        /// <summary>
        /// Create a styled Material checkbox
        /// </summary>
        /// <param name="text">Checkbox text</param>
        /// <returns>Styled MaterialCheckbox</returns>
        public static MaterialCheckbox CreateCheckbox(string text)
        {
            return new MaterialCheckbox
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Roboto", 10F)
            };
        }

        /// <summary>
        /// Apply error styling to a control
        /// </summary>
        /// <param name="control">Control to style</param>
        public static void ApplyErrorStyling(Control control)
        {
            if (control is MaterialTextBox textBox)
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                // Note: MaterialSkin handles error states internally
            }
            else
            {
                control.BackColor = Color.FromArgb(255, 235, 238); // Light red background
                control.ForeColor = ErrorColor;
            }
        }

        /// <summary>
        /// Remove error styling from a control
        /// </summary>
        /// <param name="control">Control to reset</param>
        public static void RemoveErrorStyling(Control control)
        {
            if (control is MaterialTextBox textBox)
            {
                textBox.BorderStyle = BorderStyle.None;
            }
            else
            {
                control.BackColor = SurfaceColor;
                control.ForeColor = TextPrimaryColor;
            }
        }

        /// <summary>
        /// Create a success message label
        /// </summary>
        /// <param name="text">Success message</param>
        /// <returns>Styled success label</returns>
        public static Label CreateSuccessLabel(string text)
        {
            return new Label
            {
                Text = text,
                ForeColor = SuccessColor,
                Font = new Font("Roboto", 9F, FontStyle.Regular),
                AutoSize = true
            };
        }

        /// <summary>
        /// Create an error message label
        /// </summary>
        /// <param name="text">Error message</param>
        /// <returns>Styled error label</returns>
        public static Label CreateErrorLabel(string text)
        {
            return new Label
            {
                Text = text,
                ForeColor = ErrorColor,
                Font = new Font("Roboto", 9F, FontStyle.Regular),
                AutoSize = true
            };
        }

        /// <summary>
        /// Create a section header label
        /// </summary>
        /// <param name="text">Header text</param>
        /// <returns>Styled header label</returns>
        public static MaterialLabel CreateSectionHeader(string text)
        {
            return new MaterialLabel
            {
                Text = text,
                Font = new Font("Roboto", 14F, FontStyle.Bold),
                ForeColor = TextPrimaryColor,
                AutoSize = true,
                Margin = new Padding(0, 16, 0, 8)
            };
        }

        /// <summary>
        /// Apply consistent spacing to a container
        /// </summary>
        /// <param name="container">Container to style</param>
        public static void ApplyContainerSpacing(Control container)
        {
            container.Padding = new Padding(24);
            
            if (container is Panel panel)
            {
                panel.BackColor = BackgroundColor;
            }
        }
    }
}
