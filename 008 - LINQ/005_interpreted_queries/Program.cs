/* --- Interpreted Queries --- */

/* - LINQ's Approaches - */

// 1. local queries for local object collections
// that resolves to IEnumerable<T> class

// 2. interpreted queries for remote data sources
// that resolves to IQueryable<T> interface

// Remember
// IQueryable<T> is an extension of IEnumerable<T> 
// so, everything that IEnumerable<T> does IQueryable<T>
// does as well

/* ---------------- */

/* - IEnumerable vs IQueryable - */
// The main difference is where the filter, for example,
// is going to be executed on client (in-memory) or a remote data source (database)