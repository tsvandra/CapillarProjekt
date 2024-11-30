using System.Windows.Forms;
using System.Drawing;

namespace Kupac.UI.Shared.BaseClasses
{
    public class CustomDataGridView : DataGridView
    {
        private int _lastHighlightedRowIndex = -1;
        private int _selectedRowIndex = -1;
        public CustomDataGridView()
        {
            SetModernStyle();
            this.MouseMove += CustomDataGridView_MouseMove;
            this.MouseLeave += CustomDataGridView_MouseLeave;
            this.CellClick += CustomDataGridView_CellClick;
        }

        private void CustomDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            var hit = this.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                // Visszaállítjuk az előző kiemelt sor színét, ha nem ugyanaz, mint a jelenlegi
                if (_lastHighlightedRowIndex >= 0 && _lastHighlightedRowIndex != hit.RowIndex && _lastHighlightedRowIndex != _selectedRowIndex)
                {
                    ResetRowColor(_lastHighlightedRowIndex);
                }
                // Új sor kiemelése, ha nem a kiválasztott sor
                if (hit.RowIndex != _selectedRowIndex)
                {
                    this.Rows[hit.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                _lastHighlightedRowIndex = hit.RowIndex;
            }
        }

        private void CustomDataGridView_MouseLeave(object sender, EventArgs e)
        {
            if (_lastHighlightedRowIndex >= 0 && _lastHighlightedRowIndex != _selectedRowIndex)
            {
                ResetRowColor(_lastHighlightedRowIndex);
                _lastHighlightedRowIndex = -1;
            }
        }

        private void CustomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Visszaállítjuk az előző kiválasztott sor színét, ha volt már kiválasztott sor
                if (_selectedRowIndex >= 0)
                {
                    ResetRowColor(_selectedRowIndex);
                }
                // Az új kiválasztott sor színének beállítása
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DodgerBlue;
                _selectedRowIndex = e.RowIndex;
            }
        }

        private void ResetRowColor(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < this.Rows.Count)
            {
                if (rowIndex % 2 == 0)
                {
                    this.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    this.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
        }

        private void SetModernStyle()
        {
            // Fejlec stilusanak beallitasa
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle = DataGridViewStyles.HeaderStyle();

            // Sorok stilusanak beallitasa
            this.RowsDefaultCellStyle = DataGridViewStyles.DefaultRowStyle();
            this.AlternatingRowsDefaultCellStyle = DataGridViewStyles.AlternatingRowStyle();

            //Egyeb megjelenitesi beallitasok 
            this.GridColor = Color.LightGray; 
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.RowHeadersVisible = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
