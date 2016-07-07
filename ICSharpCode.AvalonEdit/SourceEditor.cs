using System;
using System.Windows;
using System.ComponentModel;
using ICSharpCode.AvalonEdit;

namespace SourceEditor.Controls
{
  /// Temporary implementation exposing base via INotifyPropertyChanged
  public class SourceEditor : TextEditor, Notify
  {
    public static DependencyProperty CaretOffsetProperty = DependencyProperty.Register("CaretOffset", typeof(int), typeof(SourceEditor),
      new PropertyMetadata((object, arguments) =>
      {
        SourceEditor target = (SourceEditor)object;
        target.CaretOffset = (int)arguments.NewValue;
      })
    );
    
    public new string Text 
    {
      get { return base.Text; }
      set 
        {
          if(base.Text != value)
          {
            base.Text = value;
            Notify();
          }
          
        }
    }
    public new int CaretOffset 
    {
      get { return base.CaretOffset; }
      set 
        { 
          base.CaretOffset = value; 
        }
    }
    public int Length { get { return base.Text.Length; } }
    
  }
}
