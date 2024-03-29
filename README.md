

# Auction API

Auction API provides a set of APIs that can be used to create an auction event where seller can sell the his properties.

## Use cases

- Seller adds his property to the catalog and set the base price.
- Organizer will create an event where Auction will be made for the property.
- Bidders can register themselves to participate in the Auction. Organizer can set the limit to the number of bidder for a particular auction.
- During the event time, Organizer will request the Auction Intelligence API where it runs the algorithm to find the best bid and returns the Winning bidder details.

> **Assumption**: Anyone who access the application has registered and has user account. Users can be event organizer (admin), seller and bidder.

## Architecture

Considering the application to be small and simple and also not extendable from the current use cases, layered monolithic architecture has been followed.

Application is built around Domain Objects following clean architecture principles.

Application do not have data store. Any data added will be lost after the current session is closed.

Below are the List of APIs available as part of this application and same can be viewed using [https://localhost:44383/swagger/index.html](https://localhost:44383/swagger/index.html)


#### POST /properties
Seller adds his Property into the system which is needed to be sold using the above API. API will retun the added property as the response. 

Make a note of PropertyID which will be used while creating Auction Event.

**Attributes:**
- Name
- OwnerID
-  BasePrice

#### GET /properties 
Added Properties can be viewed using this API.

#### POST /events
New auction event can be created using this API. 

**Attributes:**

 - Name
 - 	Id
 - 	StartTime
 - 	EndTime
 - 	MaxBidders
 - 	PropertyID

#### GET /events
Use this API to view all created events.

#### GET /events/{eventID}
API can be used to view the details of specific event.

#### POST /biddingrecords
Once event is created, buyers can register themselves as bidders to the event using this API.

**Attributes:**

- UserID
- StartingBid
- Incrementer
- MaximumBid
- EventID

#### GET /events/{eventID}/biddingrecords
Organizer can view details of all bidders using this API

#### GET /events/{eventID}/executeauction
This API is created temporarily to trigger the automatic auction intelligence program which runs the alogrithm and returns the winning bid details.

**Result:**

- WinningBid
- WinningBiddingRecordID

## Postman Collection
Postman collection for all APIs can be found at [https://github.com/Karthik-Venkatesalu/auction-api/blob/develop/postman/Auction.postman_collection.json](https://github.com/Karthik-Venkatesalu/auction-api/blob/develop/postman/Auction.postman_collection.json)

## Swagger

Swagger UI can be viewed at https://localhost:44383/swagger/index.html and documentation is available in 