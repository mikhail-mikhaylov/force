# CQRS, Vertical Slices
Vertical Slices architecture is built around distinct requests, encapsulating and grouping all concerns from front-end to back. You take a normal "n-tier" or hexagonal/whatever architecture and remove the gates and barriers across those layers, and couple along the axis of change. The style is used and popularized by:
- Jimmy Boggard: https://jimmybogard.com/vertical-slice-architecture/, https://www.youtube.com/watch?v=SUiWfhAhgQw, https://www.youtube.com/watch?v=T6nglsEDaqA
- Steven van Deursen: https://blogs.cuttingedge.it/steven/posts/2011/meanwhile-on-the-command-side-of-my-architecture/, https://blogs.cuttingedge.it/steven/posts/2011/meanwhile-on-the-query-side-of-my-architecture/
- Maxim Arshinov: https://habr.com/ru/company/jugru/blog/447308/

## IHandler<TIn, TOut>
Todo: add docs

## ICommand<T>, ICommandHandler<TIn, TOut>
Todo: add docs

## IQuery<T>, IQueryHandler<TIn, TOut>
Todo: add docs

## FilterQuery, PagedFilterQuery
Todo: add docs