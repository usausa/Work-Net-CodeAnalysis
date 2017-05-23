namespace Smart.Net.Http.Generative.Tools
{
    public class Config
    {
        public string[] TargetDirectories { get; set; }

        public string[] ExcludeDirectories { get; set; } = { "bin", "obj" };

        public string FilePattern { get; set; } = "*.cs";
    }
}
