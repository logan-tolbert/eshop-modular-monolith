# Clean Architecture

Focused on separation of concerns and dependency rules, with source code organized into layers.
- structured design approach that ensures decoupled logic from external concerns
- ideal for large-scale applications

## Layers

1. **Domain Layer (Entities)**
    - enterprise-wide business rules
    - entities encapsulate the most general and high-level rules

2. **Application Layer (Use cases)**
    - application-specific business rules
    - encapsulates and implements use cases
    - e.g., Create, Cancel, and Update

3. **Infrastructure Layer (Interface adapter layer)**
    - converts data from entities and use cases to a format suitable for external systems
    - e.g., mapping data from database models to domain entities

4. **Infrastructure / External Concerns (Frameworks and Drivers)**
    - outermost layer, containing frameworks and tools
    - e.g., UI, Database, web framework, REST controllers, etc...


