using BlazorMonaco;

namespace UIArtify.Interfaces
{
    public interface IEditorRefresherService
    {
        void AddEditor(MonacoEditor editor);
        
        void RefreshEditor();
    }
}