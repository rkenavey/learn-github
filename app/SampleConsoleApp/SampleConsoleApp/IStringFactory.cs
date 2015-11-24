namespace SampleConsoleApp
{
    public interface IStringFactory
    {
        string CreateString(string key);

        void AddString(string key, string val);
    }
}