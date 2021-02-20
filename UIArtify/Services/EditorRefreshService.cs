using System;
using System.Collections.Generic;
using BlazorMonaco;
using Microsoft.JSInterop;
using UIArtify.Interfaces;

namespace UIArtify.Services
{
    public class EditorRefresherService : IEditorRefresherService
    {
        public static List<MonacoEditor> Editors = new();

        public void AddEditor(MonacoEditor editor)
        {
            Console.WriteLine(12);
            Editors.Add(editor);
        }
        
        public void RefreshEditor()
        {
            Console.WriteLine(22);
            Editors.ForEach(editor => editor.Layout());
        }
    }
}