using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;


namespace Assignment1.Web
{
    [ServiceContract(Namespace = "")]

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        DataClasses2DataContext db = new DataClasses2DataContext();

        [OperationContract]

        public void Insert(Payment p)
        {

            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {

                Payment pd = new Payment()

                {

                    ReservationID = p.ReservationID,
                    ReservationDate = p.ReservationDate,
                    ReservationTime = p.ReservationTime,
                    ReservationFrom = p.ReservationFrom,
                    ReservationTo = p.ReservationTo,
                    ReservationSeatNumber = p.ReservationSeatNumber,
                    ReservationTotalSeat = p.ReservationTotalSeat,
                    ReservationTotalFare = p.ReservationTotalFare,
                    ReservationBusNumber = p.ReservationBusNumber,
                    ReservationName = p.ReservationName,
                    ReservationPhoneNo = p.ReservationPhoneNo,
                    ReservationIC = p.ReservationIC,
                    PaymentAmount = p.PaymentAmount,
                   
                   

                    

                };

                db.Payments.InsertOnSubmit(pd);

                db.SubmitChanges();

            }

        }

        //[OperationContract]

        //public IList<Detail> LoadAll(String ID)
        //{

        //    using (DataClasses2DataContext db = new DataClasses2DataContext())
        //    {

        //        var records = from record in db.Details
        //                      where record.Id.ToString().StartsWith(ID)
        //                      select record;

        //        return records.ToList();

        //    }
        
        //}
        #region LoadAll(string Id)

        [OperationContract]
        List<Reservation> LoadAll(string Id)
        {
            var Find_Names = from aa in db.Reservations
                             where aa.ReservationID.ToString().StartsWith(Id)
                             select aa;

            return Find_Names.ToList();
        }

        #endregion
          

    }
}
