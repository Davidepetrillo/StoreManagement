using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Eccezioni
{
    public enum EnumExceptions
    {
        StringaVuota,
        FormatoCodiceFiscale,
        FormatoIbanException,
        DataPartenzaException,
        DataRitornoException,
        RecapitoTelefonico,
        ConnectionException,
        DisconnectionException,
        SelectException,
        OperationQueryException
    }
}
