
delegate void action();
delegate void action<T>(T t);
delegate void action<T, T1>(T t, T1 t1);
delegate void action<T, T1, T2>(T t, T1 t1, T2 t2);
delegate void action<T, T1, T2, T3>(T t, T1 t1, T2 t2, T3 t3);

delegate T   func<T>();
delegate T1 func<T, T1>(T arg1);
delegate T2 func<T, T1, T2>(T arg1, T1 arg2);
delegate T3 func<T, T1, T2, T3>(T arg1, T1 arg2, T2 arg3);

