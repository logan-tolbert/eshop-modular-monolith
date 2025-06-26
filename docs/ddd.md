# Domain Driven Design

DDD aims to solve complex problems by breaking the problem into smaller problems and focusing on the smaller problems. 

- introduced by Eric Evans in 2003

## Types of DDD

1. Strategic
    - understanding and modeling the business domain. 
    - identifying the different domains, subdomains, and their interactions
2. Tactical
    - implementation details and design patterns
    - e.g., Entities, Value Objects, Aggregates, etc...

## Concepts

- **Domain**
    - represents the whole area of business or expertise the software addresses

- **Subdomain**
    - represents a specific feature related to the domain

- **Domain Event**
    - significant occurences within a domain that need to be tracked or reacted to
    
- **Entity**
    - an object identified by it ID
    - used to represent objects that have distinct identities and lifecycles
   
- **Ubiquitous Language**
    - common language used by developers and domain experts, ensuring clarity and consistency

- **Bounded Context**
    - grouping of closely related scopes, setting a logical boundary.
    - should be as self-consistent and independent as possible

- **Value Object**
    - used to describe some characteristic or attribute with no identity (ID)
    - e.g., An address used in an order, as it is important to the order but does not define the order's identity

- **Aggregate**
    - a grouping of domain object, that is treated as a single unit
    - defines a boundary around related objects
    - e.g., An order can be an Aggregate, containing order items, payment details, etc... within the Aggregate

- **Aggregate Root**
    - the main Entity in an Aggregate, through which external objects interact with the Aggregate
    - provides a "gateway" to an Aggregate

## Analysis

### Domain Analysis

- Domain models
- Application use cases
- Rest API endpoints
- Underlying data structures

### Technical Analysis

- Architecture style
- Patterns and principles
- Libraries / packages
- Project structure

## Patterns

 
- **Context Mapping Pattern**
    - used to identify logical boundaries between domains

- Shared Kernal Pattern

A small subset of the domain model is shared between multiple bounded contexts or modules
- includes common data structures, utility classes, or services that multiple parts of the application need to use
- ensures consistency and resduces duplication between different modules
