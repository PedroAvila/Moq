using System;

namespace CreditCardApplications
{
    public class FrequentFlyerNumberValidatorService : IFrequentFlyerNumberValidator
    {

        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }

        public event EventHandler ValidatorLookupPerformed;

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }

        //public string LicenseKey
        //{
        //    get
        //    {
        //        throw new NotImplementedException("For demo purposes");
        //    }
        //}

        public IServiceInformation ServiceInformation => throw new NotImplementedException();

        public ValidationMode ValidationMode
        {
            get => throw new NotImplementedException("For demo purposes");
            set => throw new NotImplementedException("For demo purposes");
        }

    }
}
