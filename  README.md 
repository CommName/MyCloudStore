# Abaout

This is a student project that implements some of basic cryptographic algorithms. This projects consists of 3 smaller projects:
    - Client - uses cryptolibrary to encode and decode files before sending them to service for permanent storage. 
    - CryptoLibrary - implements algorithms for coding and decoding array of bytes.
    - Service - stores files and manages that the right clients can access them.

# Crypto algorithms

There are five algorithms implemented:
    - A5/2
    - CTR 
    - RC4
    - RSA
    - TigerHash


# A52 

A5/2 is a stream cipher used to provide voice privacy in the GSM cellular telephone protocol. It was used for export instead of the relatively stronger (but still weak) A5/1. It is one of seven A5 ciphering algorithms which have been defined for GSM use.
The cipher is based on a combination of four linear feedback shift registers with irregular clocking and a non-linear combiner.
In 1999, Ian Goldberg and David A. Wagner cryptanalyzed A5/2 in the same month it was published, and showed that it was extremely weak – so much so that low end equipment can probably break it in real time.
Since July 1, 2006, the GSMA (GSM Association) mandated that GSM Mobile Phones will not support the A5/2 Cipher any longer, due to its weakness, and the fact that A5/1 is deemed mandatory by the 3GPP association. In July 2007, the 3GPP has approved a change request to prohibit the implementation of A5/2 in any new mobile phones. If the network does not support A5/1, or any other A5 algorithm implemented by the phone, then an unencrypted connection can be used

# CTR 
In cryptography, a block cipher mode of operation is an algorithm that uses a block cipher to provide information security such as confidentiality or authenticity. A block cipher by itself is only suitable for the secure cryptographic transformation (encryption or decryption) of one fixed-length group of bits called a block A mode of operation describes how to repeatedly apply a cipher's single-block operation to securely transform amounts of data larger than a block.

CTR mode (CM) is also known as integer counter mode (ICM) and segmented integer counter (SIC) mode.
Like OFB, counter mode turns a block cipher into a stream cipher. It generates the next keystream block by encrypting successive values of a "counter". The counter can be any function which produces a sequence which is guaranteed not to repeat for a long time, although an actual increment-by-one counter is the simplest and most popular. The usage of a simple deterministic input function used to be controversial; critics argued that "deliberately exposing a cryptosystem to a known systematic input represents an unnecessary risk."[29] However, today CTR mode is widely accepted and any problems are considered a weakness of the underlying block cipher, which is expected to be secure regardless of systemic bias in its input.[30] Along with CBC, CTR mode is one of two block cipher modes recommended by Niels Ferguson and Bruce Schneier.
CTR mode was introduced by Whitfield Diffie and Martin Hellman in 1979.
CTR mode has similar characteristics to OFB, but also allows a random access property during decryption. CTR mode is well suited to operate on a multi-processor machine where blocks can be encrypted in parallel. Furthermore, it does not suffer from the short-cycle problem that can affect OFB.
If the IV/nonce is random, then they can be combined together with the counter using any invertible operation (concatenation, addition, or XOR) to produce the actual unique counter block for encryption. In case of a non-random nonce (such as a packet counter), the nonce and counter should be concatenated (e.g., storing the nonce in the upper 64 bits and the counter in the lower 64 bits of a 128-bit counter block). Simply adding or XORing the nonce and counter into a single value would break the security under a chosen-plaintext attack in many cases, since the attacker may be able to manipulate the entire IV–counter pair to cause a collision. Once an attacker controls the IV–counter pair and plaintext, XOR of the ciphertext with the known plaintext would yield a value that, when XORed with the ciphertext of the other block sharing the same IV–counter pair, would decrypt that block.
Note that the nonce in this diagram is equivalent to the initialization vector (IV) in the other diagrams. However, if the offset/location information is corrupt, it will be impossible to partially recover such data due to the dependence on byte offset. 

![CTR enc](./Images/CTRenc.png) 
![CTR dec](./Images/CTRdec.png)


# RC4
RC4 is an encryption algorithm that was created by Ronald Rivest of RSA Security. It is usedin WEP and WPA, which are encryption protocols commonly used on wireless routers. Theworkings of RC4 used to be a secret, but its code was leaked onto the internet in 1994.RC4 wasoriginally very widely used due to its simplicity and speed. Typically 16 byte keys are used forstrong encryption, but shorter key lengths are also widely used due to export restrictions. Overtime this code was shown to produce biased outputs towards certain sequences, mostly in firstfew bytes of the keystream generated.

# RSA

**IMPORTANT** This implementation doesn't contain generation of public and private keys, only encryption and decryption

RSA (Rivest–Shamir–Adleman) is a public-key cryptosystem that is widely used for secure data transmission. It is also one of the oldest. The acronym RSA comes from the surnames of Ron Rivest, Adi Shamir, and Leonard Adleman, who publicly described the algorithm in 1977. An equivalent system was developed secretly, in 1973 at GCHQ (the British signals intelligence agency), by the English mathematician Clifford Cocks. That system was declassified in 1997.

# TigerHash

This is not a crypto algorithm, but it is used to check if decryption is sucessfull.
In cryptography, Tiger is a cryptographic hash function designed by Ross Anderson and Eli Biham in 1995 for efficiency on 64-bit platforms. The size of a Tiger hash value is 192 bits. Truncated versions (known as Tiger/128 and Tiger/160) can be used for compatibility with protocols assuming a particular hash size. Unlike the SHA-2 family, no distinguishing initialization values are defined; they are simply prefixes of the full Tiger/192 hash value. 