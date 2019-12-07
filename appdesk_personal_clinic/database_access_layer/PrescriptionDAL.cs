﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class PrescriptionDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.PRESCRIPTIONDataTable getData()
        {
            PersonalClinicDataSet.PRESCRIPTIONDataTable tblPrescription = new PRESCRIPTIONTableAdapter().GetData();
            return tblPrescription;
        }

        public int updateCorePrescription(PrescriptionDTO originalPrescription)
        {

            int flagUpdate = new PRESCRIPTIONTableAdapter().updatePrescriptionQuery(
                originalPrescription.IdPatient,
                originalPrescription.ConclusionMedical,
                originalPrescription.Price,
                originalPrescription.IdPrescription
                );

            return flagUpdate;
        }

        public int insertCorePrescription(PrescriptionDTO newPrescription)
        {
            int flagInsert = new PRESCRIPTIONTableAdapter().insertPrescriptionQuery(
                newPrescription.IdPatient,
                newPrescription.ConclusionMedical,
                newPrescription.Price
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}