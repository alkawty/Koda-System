using System.Drawing;
using System.Windows.Forms;
using System;

public class CustomMenuRenderer : ToolStripProfessionalRenderer
{
    
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
        
        if (e.Item.Selected)
        {
            e.Graphics.FillRectangle(
                new SolidBrush(Color.DodgerBlue), rect);
        }
        else
        {
            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(0, 171, 120)), rect);
        }
    }

    
    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        if (e.Item.Selected) 
            e.TextColor = Color.White;
        else
            e.TextColor = Color.LightGray;

        e.TextFont = new Font("Al-Jazeera-Arabic-Bold", 11, FontStyle.Bold);
        
        base.OnRenderItemText(e);
    }


    private void AdjustDropDownWidth(ToolStripMenuItem menuItem)
    {
        int maxWidth = 0;

        foreach (ToolStripItem item in menuItem.DropDownItems)
        {
            int textWidth = TextRenderer.MeasureText(item.Text, item.Font).Width;
            maxWidth = Math.Max(maxWidth, textWidth);
        }

        menuItem.DropDown.AutoSize = false;
        menuItem.DropDown.Width = maxWidth + 60; 
    }






}
