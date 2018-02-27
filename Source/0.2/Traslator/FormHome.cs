/*
Fenix Translator 0.2
© Ismael Heredia , Argentina , 2014
Credits : Based in Google Translate
Thanks to Google Translate
GitHub : https://github.com/IsmaelHeredia
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace Traslator
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {

            string codigouno = "";
            string codigodos = "";

            if (cmbLanguage1.Text == "Afrikaans")
            {
                codigouno = "af";
            }


            if (cmbLanguage1.Text == "Arabe")
            {
                codigouno = "ar";
            }


            if (cmbLanguage1.Text == "Azeri")
            {
                codigouno = "az";
            }


            if (cmbLanguage1.Text == "Bielorruso")
            {
                codigouno = "be";
            }


            if (cmbLanguage1.Text == "BÀlgaro")
            {
                codigouno = "bg";
            }


            if (cmbLanguage1.Text == "Bangla")
            {
                codigouno = "bn";
            }


            if (cmbLanguage1.Text == "Bosnio")
            {
                codigouno = "bs";
            }


            if (cmbLanguage1.Text == "Catalan")
            {
                codigouno = "ca";
            }


            if (cmbLanguage1.Text == "Cebuano")
            {
                codigouno = "ceb";
            }


            if (cmbLanguage1.Text == "Checo")
            {
                codigouno = "cs";
            }


            if (cmbLanguage1.Text == "Gales")
            {
                codigouno = "cy";
            }


            if (cmbLanguage1.Text == "Danes")
            {
                codigouno = "da";
            }


            if (cmbLanguage1.Text == "Aleman")
            {
                codigouno = "de";
            }


            if (cmbLanguage1.Text == "Griego")
            {
                codigouno = "el";
            }


            if (cmbLanguage1.Text == "Ingles")
            {
                codigouno = "en";
            }


            if (cmbLanguage1.Text == "Esperanto")
            {
                codigouno = "eo";
            }


            if (cmbLanguage1.Text == "Español")
            {
                codigouno = "es";
            }


            if (cmbLanguage1.Text == "Estonio")
            {
                codigouno = "et";
            }


            if (cmbLanguage1.Text == "Euskera")
            {
                codigouno = "eu";
            }


            if (cmbLanguage1.Text == "Persa")
            {
                codigouno = "fa";
            }


            if (cmbLanguage1.Text == "Finlandes")
            {
                codigouno = "fi";
            }


            if (cmbLanguage1.Text == "Frances")
            {
                codigouno = "fr";
            }


            if (cmbLanguage1.Text == "Irlandes")
            {
                codigouno = "ga";
            }


            if (cmbLanguage1.Text == "Gallego")
            {
                codigouno = "gl";
            }


            if (cmbLanguage1.Text == "Gujarati")
            {
                codigouno = "gu";
            }


            if (cmbLanguage1.Text == "Hindi")
            {
                codigouno = "hi";
            }


            if (cmbLanguage1.Text == "Hmong")
            {
                codigouno = "hmn";
            }


            if (cmbLanguage1.Text == "Croata")
            {
                codigouno = "hr";
            }


            if (cmbLanguage1.Text == "Criollo haitiano")
            {
                codigouno = "ht";
            }


            if (cmbLanguage1.Text == "Hungaro")
            {
                codigouno = "hu";
            }


            if (cmbLanguage1.Text == "Armenio")
            {
                codigouno = "hy";
            }


            if (cmbLanguage1.Text == "Indonesio")
            {
                codigouno = "id";
            }


            if (cmbLanguage1.Text == "Italian")
            {
                codigouno = "it";
            }


            if (cmbLanguage1.Text == "Hebreo")
            {
                codigouno = "iw";
            }


            if (cmbLanguage1.Text == "Japones")
            {
                codigouno = "ja";
            }


            if (cmbLanguage1.Text == "Javanes")
            {
                codigouno = "jw";
            }


            if (cmbLanguage1.Text == "Georgiano")
            {
                codigouno = "ka";
            }


            if (cmbLanguage1.Text == "Jemer")
            {
                codigouno = "km";
            }


            if (cmbLanguage1.Text == "Canares")
            {
                codigouno = "kn";
            }


            if (cmbLanguage1.Text == "Coreano")
            {
                codigouno = "ko";
            }


            if (cmbLanguage1.Text == "Latin")
            {
                codigouno = "la";
            }


            if (cmbLanguage1.Text == "Loa")
            {
                codigouno = "lo";
            }


            if (cmbLanguage1.Text == "Lituano")
            {
                codigouno = "lt";
            }


            if (cmbLanguage1.Text == "Leton")
            {
                codigouno = "lv";
            }


            if (cmbLanguage1.Text == "Macedonio")
            {
                codigouno = "mk";
            }


            if (cmbLanguage1.Text == "Marati")
            {
                codigouno = "mr";
            }


            if (cmbLanguage1.Text == "Malayo")
            {
                codigouno = "ms";
            }


            if (cmbLanguage1.Text == "Maltes")
            {
                codigouno = "mt";
            }


            if (cmbLanguage1.Text == "Holandes")
            {
                codigouno = "nl";
            }


            if (cmbLanguage1.Text == "Noruego")
            {
                codigouno = "no";
            }


            if (cmbLanguage1.Text == "Polaco")
            {
                codigouno = "pl";
            }


            if (cmbLanguage1.Text == "Portugues")
            {
                codigouno = "pt";
            }


            if (cmbLanguage1.Text == "Rumano")
            {
                codigouno = "ro";
            }


            if (cmbLanguage1.Text == "Ruso")
            {
                codigouno = "ru";
            }


            if (cmbLanguage1.Text == "Eslovaco")
            {
                codigouno = "sk";
            }


            if (cmbLanguage1.Text == "Esloveno")
            {
                codigouno = "sl";
            }


            if (cmbLanguage1.Text == "Albanes")
            {
                codigouno = "sq";
            }


            if (cmbLanguage1.Text == "Serbio")
            {
                codigouno = "sr";
            }


            if (cmbLanguage1.Text == "Sueco")
            {
                codigouno = "sv";
            }


            if (cmbLanguage1.Text == "Suajili")
            {
                codigouno = "sw";
            }


            if (cmbLanguage1.Text == "Tamil")
            {
                codigouno = "ta";
            }


            if (cmbLanguage1.Text == "Telegu")
            {
                codigouno = "te";
            }


            if (cmbLanguage1.Text == "Tailandes")
            {
                codigouno = "th";
            }


            if (cmbLanguage1.Text == "Talago")
            {
                codigouno = "tl";
            }


            if (cmbLanguage1.Text == "Turco")
            {
                codigouno = "tr";
            }


            if (cmbLanguage1.Text == "Ucraniano")
            {
                codigouno = "uk";
            }


            if (cmbLanguage1.Text == "Urdu")
            {
                codigouno = "ur";
            }


            if (cmbLanguage1.Text == "Vietnamita")
            {
                codigouno = "vi";
            }


            if (cmbLanguage1.Text == "Yidis")
            {
                codigouno = "yi";
            }


            if (cmbLanguage1.Text == "Chino")
            {
                codigouno = "zh_CN";
            }


            if (cmbLanguage2.Text == "Afrikaans")
            {
                codigodos = "af";
            }


            if (cmbLanguage2.Text == "Arabe")
            {
                codigodos = "ar";
            }


            if (cmbLanguage2.Text == "Azeri")
            {
                codigodos = "az";
            }


            if (cmbLanguage2.Text == "Bielorruso")
            {
                codigodos = "be";
            }


            if (cmbLanguage2.Text == "BÀlgaro")
            {
                codigodos = "bg";
            }


            if (cmbLanguage2.Text == "Bangla")
            {
                codigodos = "bn";
            }


            if (cmbLanguage2.Text == "Bosnio")
            {
                codigodos = "bs";
            }


            if (cmbLanguage2.Text == "Catalan")
            {
                codigodos = "ca";
            }


            if (cmbLanguage2.Text == "Cebuano")
            {
                codigodos = "ceb";
            }


            if (cmbLanguage2.Text == "Checo")
            {
                codigodos = "cs";
            }


            if (cmbLanguage2.Text == "Gales")
            {
                codigodos = "cy";
            }


            if (cmbLanguage2.Text == "Danes")
            {
                codigodos = "da";
            }


            if (cmbLanguage2.Text == "Aleman")
            {
                codigodos = "de";
            }


            if (cmbLanguage2.Text == "Griego")
            {
                codigodos = "el";
            }


            if (cmbLanguage2.Text == "Ingles")
            {
                codigodos = "en";
            }


            if (cmbLanguage2.Text == "Esperanto")
            {
                codigodos = "eo";
            }


            if (cmbLanguage2.Text == "Español")
            {
                codigodos = "es";
            }


            if (cmbLanguage2.Text == "Estonio")
            {
                codigodos = "et";
            }


            if (cmbLanguage2.Text == "Euskera")
            {
                codigodos = "eu";
            }


            if (cmbLanguage2.Text == "Persa")
            {
                codigodos = "fa";
            }


            if (cmbLanguage2.Text == "Finlandes")
            {
                codigodos = "fi";
            }


            if (cmbLanguage2.Text == "Frances")
            {
                codigodos = "fr";
            }


            if (cmbLanguage2.Text == "Irlandes")
            {
                codigodos = "ga";
            }


            if (cmbLanguage2.Text == "Gallego")
            {
                codigodos = "gl";
            }


            if (cmbLanguage2.Text == "Gujarati")
            {
                codigodos = "gu";
            }


            if (cmbLanguage2.Text == "Hindi")
            {
                codigodos = "hi";
            }


            if (cmbLanguage2.Text == "Hmong")
            {
                codigodos = "hmn";
            }


            if (cmbLanguage2.Text == "Croata")
            {
                codigodos = "hr";
            }


            if (cmbLanguage2.Text == "Criollo haitiano")
            {
                codigodos = "ht";
            }


            if (cmbLanguage2.Text == "Hungaro")
            {
                codigodos = "hu";
            }


            if (cmbLanguage2.Text == "Armenio")
            {
                codigodos = "hy";
            }


            if (cmbLanguage2.Text == "Indonesio")
            {
                codigodos = "id";
            }


            if (cmbLanguage2.Text == "Italian")
            {
                codigodos = "it";
            }


            if (cmbLanguage2.Text == "Hebreo")
            {
                codigodos = "iw";
            }


            if (cmbLanguage2.Text == "Japones")
            {
                codigodos = "ja";
            }


            if (cmbLanguage2.Text == "Javanes")
            {
                codigodos = "jw";
            }


            if (cmbLanguage2.Text == "Georgiano")
            {
                codigodos = "ka";
            }


            if (cmbLanguage2.Text == "Jemer")
            {
                codigodos = "km";
            }


            if (cmbLanguage2.Text == "Canares")
            {
                codigodos = "kn";
            }


            if (cmbLanguage2.Text == "Coreano")
            {
                codigodos = "ko";
            }


            if (cmbLanguage2.Text == "Latin")
            {
                codigodos = "la";
            }


            if (cmbLanguage2.Text == "Loa")
            {
                codigodos = "lo";
            }


            if (cmbLanguage2.Text == "Lituano")
            {
                codigodos = "lt";
            }


            if (cmbLanguage2.Text == "Leton")
            {
                codigodos = "lv";
            }


            if (cmbLanguage2.Text == "Macedonio")
            {
                codigodos = "mk";
            }


            if (cmbLanguage2.Text == "Marati")
            {
                codigodos = "mr";
            }


            if (cmbLanguage2.Text == "Malayo")
            {
                codigodos = "ms";
            }


            if (cmbLanguage2.Text == "Maltes")
            {
                codigodos = "mt";
            }


            if (cmbLanguage2.Text == "Holandes")
            {
                codigodos = "nl";
            }


            if (cmbLanguage2.Text == "Noruego")
            {
                codigodos = "no";
            }


            if (cmbLanguage2.Text == "Polaco")
            {
                codigodos = "pl";
            }


            if (cmbLanguage2.Text == "Portugues")
            {
                codigodos = "pt";
            }


            if (cmbLanguage2.Text == "Rumano")
            {
                codigodos = "ro";
            }


            if (cmbLanguage2.Text == "Ruso")
            {
                codigodos = "ru";
            }


            if (cmbLanguage2.Text == "Eslovaco")
            {
                codigodos = "sk";
            }


            if (cmbLanguage2.Text == "Esloveno")
            {
                codigodos = "sl";
            }


            if (cmbLanguage2.Text == "Albanes")
            {
                codigodos = "sq";
            }


            if (cmbLanguage2.Text == "Serbio")
            {
                codigodos = "sr";
            }


            if (cmbLanguage2.Text == "Sueco")
            {
                codigodos = "sv";
            }


            if (cmbLanguage2.Text == "Suajili")
            {
                codigodos = "sw";
            }


            if (cmbLanguage2.Text == "Tamil")
            {
                codigodos = "ta";
            }


            if (cmbLanguage2.Text == "Telegu")
            {
                codigodos = "te";
            }


            if (cmbLanguage2.Text == "Tailandes")
            {
                codigodos = "th";
            }


            if (cmbLanguage2.Text == "Talago")
            {
                codigodos = "tl";
            }


            if (cmbLanguage2.Text == "Turco")
            {
                codigodos = "tr";
            }


            if (cmbLanguage2.Text == "Ucraniano")
            {
                codigodos = "uk";
            }


            if (cmbLanguage2.Text == "Urdu")
            {
                codigodos = "ur";
            }


            if (cmbLanguage2.Text == "Vietnamita")
            {
                codigodos = "vi";
            }


            if (cmbLanguage2.Text == "Yidis")
            {
                codigodos = "yi";
            }


            if (cmbLanguage2.Text == "Chino")
            {
                codigodos = "zh_CN";
            }

            string texto = rtbText.Text;
            texto = texto.Replace("\n", " ");

            rtbOutput.Clear();

            WebClient metodoget = new WebClient();
            metodoget.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            string contenido = metodoget.DownloadString("http://translate.google.com/translate_a/t?client=t&text="+texto+"&sl="+codigouno+"&tl="+codigodos);

            contenido = contenido.Replace("[", "-");
            Match buscar = Regex.Match(contenido,"---\"(.*?)\"", RegexOptions.IgnoreCase);
            if (buscar.Success)
            {
                string mostrar = buscar.Groups[1].Value;
                mostrar = mostrar.Replace("Â¡", "");
                rtbOutput.AppendText(mostrar);
            }


        }

    }
}
