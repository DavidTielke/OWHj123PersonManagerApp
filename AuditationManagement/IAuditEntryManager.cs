﻿using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Logic.Domain.AuditationManagement;

public interface IAuditEntryManager
{
    void Add(AuditEntry entry);
}