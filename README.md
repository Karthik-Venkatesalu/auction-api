
# Auction

Auction provides a set of APIs that can be used to create an auction event where seller can sell the his properties.

## Use cases

- Seller adds his property to the catalog and set the base price.
- Organizer will create an event where Auction will be made for the property.
- Bidders can register themselves to participate in the Auction. Only first five bidders are allowed.
- During the event time, Organizer will request the Auction Intelligence Machine to perform the algorithm
and return the Winning bidder.

> **Assumption**: Anyone who access the application has registered and has user account. Users can be event organizer (admin), seller and bidder.

## Architecture

Considering the application to be monolithic and also not extendable from the current use cases, I have followed the layered architecture.

Application is built around Domain Objects where it has access only to Business and Business will be accessed by the external service to perform the operations and persist the data.

> Application flow will be like follows:
> 
> API Controller -> Service -> Business ( persistence is injected) ->
> Domain Objects
