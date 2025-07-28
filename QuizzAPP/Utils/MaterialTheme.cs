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
        public static readonly Color BackgroundColor = Color.FromArgb(250, 250, 250);  // Grey 50
        public static readonly Color ErrorColor = Color.FromArgb(244, 67, 54);         // Red 500
        public static readonly Color SuccessColor = Color.FromArgb(76, 175, 80);       // Green 500
        public static readonly Color WarningColor = Color.FromArgb(255, 152, 0);       // Orange 500

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




    }
}
