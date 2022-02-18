using Dicom;
using RIS_EMSL.Models;
using RIS_EMSL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS_EMSL.Services
{
    public class DicomService
    {
        internal Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForUIAsync(DicomDataset qyeryDatasets)
        {
            return new DicomRepository().QueryStudyDatabaseDatasetsForUIAsync(qyeryDatasets);
        }

        internal Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForMoveAsync(DicomDataset moveDataset)
        {
            return new DicomRepository().QueryStudyDatabaseDatasetsForMoveAsync(moveDataset);
        }
    }
}
