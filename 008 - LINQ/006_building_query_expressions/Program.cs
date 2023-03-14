/* --- Building Query Expressions --- */

/* - Expressions Trees - */

// They are used by LINQ remote provides as data structures
// that creates a query in runtime

// These provides are implemented by IQueryable<T> interface

// It holds the actual elements of a query, but not query's result

// They wraps a delegate (Expression<TDelegate>) 
// When compiled, an expression tree goes to a remote source
// for example, translates to SQL statement and execute on a database

// A TDelegate such as Func<T>, when compiled is converted 
// to an executable code (to a Intermediate Language - IL) 
// and performed in-memory (it's hard to convert to IL first and them to SQL statement)

/* ---------------- */

/* - AsEnumerable() - */
// It cast an IQueryable<T> sequence to IEnumerable<T>
// to act like a remainder of the query to execute locally

/* - AsQueryable() - */
// It lets you write queries that can run either locally or remotely
