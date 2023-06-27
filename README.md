# Understanding principles of security: Integrity, Creating a Hash

Hashing Properties
Hashing is one-way mathematical function that is relatively easy to compute, but significantly harder to reverse.

The input can be any length.
The output has a fixed length.
The hash function is one way and is not reversible.
Two different input values will almost never result in the same hash values.
Hashing algorithms
The 8-bit checksum is one of the first hashing algorithms, and it is the simple form of a hash function. An 8-bit checksum calculates the hash by converting the message into binary numbers and then organizing the string of binary numbers into 8-bit chucks. The algorithm adds up the 8-bit values. The final step is to convert the result using a process called 2's complement.

Modern Hashing Algorithms
Two of the most popular modern hashing algorithms are MD5 and SHA.

Message Digest 5 (MD5) Algorithm
MD5 is one-way function that makes it easy to compute a hash from the given input data but makes it very difficult to compute input data given only a hash value. MD5 produces a 128-bit hash value.

Secure Hash Algorithm
SHA-2 algorithms are the secure hash algorithms that the U.S government requires by law for use in certain applications. This includes use in other cryptographic algorithms and protocols, for the protection or sensitive unclassified information. SHA-2 replaced SHA-1 with four additional hash functions:

SHA-224 (224 bits)
SHA-256 (256 bits)
SHA-384 (384 bits)
SHA-512 (512 bits)
SHA-2 is a stronger algorithm, and it is replacing MD5. The SHA family is the next-generation algorithms. The following program shows how to implement modern hashing algorithms with C#.
Download the source code here.

Fig 1. Running the program, compare different algorithms.
<img src="hasproperties/fig1.png">

Fig 2. Running the program, comparing and contrasting different outputs.

When choosing a hashing algorithm, use SHA-256 or higher as they are currently the most secure. In production implement SHA-256 or higher.

 Download example source code.
 Download example source code (GTK#).
