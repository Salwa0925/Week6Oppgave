# Using Thread + Join

* When running two drones in **Thread**, the program prints out everything randomly. 
* The terminal was printing out in a random order in the begining, by adding **thread.join()** the two drones were seperated.
* before adding the **thread.sleep()** method, everything was printed in one go, by adding this method it printes according to the ms that it is assigned.
* The Message Of a succsessfull landing comes at the end of the output.

# Using Task + TaskCompletionSource (TCS)

* Wehn running two drones using **TCS**, the outprint is very random. (not sure in how to seperate the drones.) 


# Using FlyTwoDronesWithAsync (async/await)

* When running two drones using **Async** it is exactily the same output as **TCS**.
* The main and most important difference is the fact that it takes less time to write a code with Async compared to TCS.

* At the same time it is less confusing given the fact that the preimplemented code (**Await**) makes everything smother.


