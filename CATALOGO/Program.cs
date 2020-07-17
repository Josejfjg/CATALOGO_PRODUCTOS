using SpreadsheetLight;
using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CATALOGO
{
    public static class Program
    {


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(_frmLogin.Execute(_Trastienda));

            CatalogoObj.TTrastienda _Trastienda = new CatalogoObj.TTrastienda();

            Seguridad.frmLogin _frmLogin = new Seguridad.frmLogin();


            if (!_frmLogin.Execute(_Trastienda))
            {
                frmPrincipal _frmPrincipal = new frmPrincipal();
                _frmPrincipal.Execute(_Trastienda);

            }
        }
        /// <summary>
        /// Funcion para exportar a un documento xmls desde un datagrid
        /// </summary>
        public static void Exportar_Excel_DataGrid(DataGridView _dataGridView)
        {
            try
            {
                SLDocument _sl = new SLDocument();
                SLStyle _style = new SLStyle();
                //_style.Font.FontSize = 20;
                //_style.Font.Bold = true;            
                _style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightBlue, System.Drawing.Color.Black);

                int _iC = 1;
                int _iCR = 0;
                foreach (DataGridViewColumn _column in _dataGridView.Columns)
                {
                    if(_column.Visible)                  
                    {
                        _sl.SetCellValue(1, _iC, _column.HeaderText.ToString());
                        _sl.SetCellStyle(1, _iC, _style);
                        int _iR = 2;
                        foreach (DataGridViewRow _row in _dataGridView.Rows)
                        {
                            _sl.SetCellValue(_iR, _iC, _row.Cells[_iCR].Value.ToString());
                            _iR++;
                        }                       
                        _iC++;
                    } 
                    _iCR++;
                }
                _sl.AutoFitColumn(1, _iC);
                _sl.AutoFitRow(1, _iC);
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "Reporte" + DateTime.Now.ToString("ddMMyyyy"); 
                dlg.DefaultExt = ".txt"; 
                dlg.Filter = "Excel (.xlsx)|*.xlsx"; 
                                              
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    string filename = dlg.FileName;
                    _sl.SaveAs(filename);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }


        }
    }
}
