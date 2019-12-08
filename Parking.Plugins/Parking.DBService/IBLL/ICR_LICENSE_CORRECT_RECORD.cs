namespace Parking.DBService.IBLL
{
    public interface ICR_LICENSE_CORRECT_RECORD
    {
        bool Add(Parking.Core.Model.CR_LICENSE_CORRECT_RECORD model);
        void InitRecognitioInfo();
    }
}