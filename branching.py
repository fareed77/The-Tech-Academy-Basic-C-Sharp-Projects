# this code welcomes the user
print("Welcome to Package Express. Please follow the instructions below.")

# this code will bring up a prompt that will make the user enter the weight of the package
try:
    weight = float(input("Please enter the package weight: "))

    # this code checks if the package is too heavy or not
    if weight > 50:
        print("Package too heavy to be shipped via Package Express.") # this happens if the package is too heavy
    else:
        # if the package is not too heavy this code will tell the user to put the dimentions
        width = float(input("Please enter the package width: "))
        height = float(input("Please enter the package height: "))
        length = float(input("Please enter the package length: "))

        # this code will help check the dimentions limit for the package
        if (width + height + length) > 50:
            print("Package too big to be shipped via Package Express.") # this will be displayed if the package dimentions are too big
        else:
            # this calculates the shipping quote
            volume = width * height * length  # this calculates the package volume
            quote = (volume * weight) / 100  # this calculate the quote based on the formula

            # this will display the shipping quote
            print(f"Your estimated total for shipping this package is: ${quote:.2f}")
            print("Thank you!") # simple thank you at the end
except ValueError:
    # this will be put on the screen if the user puts something that is invalid
    print("Invalid input. Please enter numeric values only.")