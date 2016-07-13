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
          	PropertyChanging();
            base.Text = value;
            PropertyChanged();
          }
          
        }
    }
    public new int CaretOffset 
    {
      get { return base.CaretOffset; }
      set 
        { 
        	if(base.CaretOffset != value)
        	{
        		PropertyChanging();
          		base.CaretOffset = value; 
          		PropertyChanged();
        	}
        }
    }
    public int Length { get { return base.Text.Length; } }
    
  }
}
