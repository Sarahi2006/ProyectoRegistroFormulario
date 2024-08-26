using System;

namespace CustomEventLibrary
{
    public class DocumentNumberValidator
    {
       
        public event EventHandler<string> ValidationFailed;

        public bool ValidateDocumentNumber(string documentNumber)
        {
            if (!IsValidDocumentNumber(documentNumber))
            {
                OnValidationFailed(documentNumber);
                return false;
            }

            return true;
        }

   
        protected virtual bool IsValidDocumentNumber(string documentNumber)
        {

            return documentNumber.Length == 7 && long.TryParse(documentNumber, out _);
        }

    
        protected virtual void OnValidationFailed(string documentNumber)
        {
            ValidationFailed?.Invoke(this, documentNumber);
        }

        
    }
}
