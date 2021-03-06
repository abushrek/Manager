﻿using System.Collections.Generic;
using Manager.Model.Interfaces;

namespace Manager.SaveManagement
{
    public interface IXmlManager
    {
        void CreateNewXmlFile(IReadOnlyCollection<IBaseRecord> recordList);
        void CreateNewXmlFile(params IBaseRecord[] records);
        void RemoveXmlRecord(IBaseRecord rec);
        void AppendXmlFile(IBaseRecord rec);
        void EditXmlRecord(IBaseRecord rec, IBaseRecord newRecord);
        List<IBaseRecord> LoadXmlFile();
    }
}