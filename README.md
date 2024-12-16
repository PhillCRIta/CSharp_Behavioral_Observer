### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Observer pattern
 OBSERVER PATTERN \
 otherwise know \
 PUBLISHER/SUBSCRIBER PATTER *PUBSUB PATTERN* \
 In naive format there are violations of solid principle SingleResponsability, the class datasource storing data and manage the dependents observer objects. \
 OpenClose principle, for every new observer object you need to modify datasource class. 
 
 Datasource clas manage the values. \
 List of observers is manage by Subject class.
 
 Can be used with Mediator Pattern