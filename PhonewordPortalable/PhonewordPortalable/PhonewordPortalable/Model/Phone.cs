namespace PhonewordPortalable
{
    public class Phone
    {
        public Phone(string originalNumber, string translatedNumber)
        {
            OriginalNumber = originalNumber;
            TanslatedNumber = translatedNumber;
        }
        public string OriginalNumber { get; set; }
        public string TanslatedNumber { get; set; }
    }
}
