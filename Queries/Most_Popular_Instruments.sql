SELECT Instruments.[Instrument Name], Count(Students.[StudentID]) AS Used
FROM Instruments INNER JOIN Students ON Instruments.[InstrumentID] = Students.[InstrumentID]
GROUP BY Instruments.[Instrument Name];