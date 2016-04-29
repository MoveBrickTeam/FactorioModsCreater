using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FactorioModsCreater.ApplicationInit
{
    public interface IFmcInit
    {
        void Init(Form targetForm);
    }
}