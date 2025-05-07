# OldPhone_IronSoftware_ConsoleApp
Iron Software C# Coding Challenge
This project simulates of **old phone keypads**.


## How It Works

You enter a string of numbers representing key presses on an old phone pad, ending with `#`.

**Special Rules:**
- `#` → End of input (must be included).
- `*` → Removes the previous character.
- Space (`' '`) → Is separator between letters (especially for repeated keys).
- `0` → To add space character ( ' ' ).

---

## Examples

```csharp
OldPhonePad("222 2 22#")            // Output: "CAB"
OldPhonePad("33#")                  // Output: "E"
OldPhonePad("227*#")                // Output: "B"
OldPhonePad("4433555 555666#")      // Output: "HELLO"
OldPhonePad("8 88777444666*664#")   // Output: "TURING"
OldPhonePad("2224424444664062444#")   // Output: "CHIANG MAI"