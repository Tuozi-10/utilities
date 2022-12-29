namespace src.Editor
{
    public class DependencyAssignerException : System.Exception
    {
        public DependencyAssignerException(string path) :
            base($"Failed to assign dependency at path {path}")
        {}
    }
}