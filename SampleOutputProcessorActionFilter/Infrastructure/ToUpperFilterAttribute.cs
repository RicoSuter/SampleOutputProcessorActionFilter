namespace SampleOutputProcessorActionFilter.Infrastructure
{
    public class ToUpperFilterAttribute : OutputProcessorActionFilterAttribute
    {
        protected override string Process(string data)
        {
            return data.ToUpper();
        }
    }
}