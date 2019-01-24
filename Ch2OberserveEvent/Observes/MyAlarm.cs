// using System;

// namespace HeadFirstDesignPatterns.Ch2OberserveEvent.Observes
// {
//     public class MyAlarm
//     {
//         private int  _alarmTime;
//         private Datatime _now;

//         public void SetAlarmTime(TimeSpan timeSpan)
//         {
//             _alarmTime = _now().Add(timeSpan);
//             RunBackgourndRunner(_now, _alarmTime);
//         }
//     }
// }