class ParliamentHouse:
    def __init__(self):
        self.members = []

    def add_member(self):
        name = input("Enter the name of the member to add: ")
        if name.isalpha():
            self.members.append(name)
            print("Member added successfully.")
        else:
            print("Invalid name. Only alphabetic characters are allowed.")

    def display_members(self):
        if not self.members:
            print("No members added yet.\n")
        else:
            print("Members:\n")
            for member in self.members:
                print(member)

    def delete_member(self):
        if not self.members:
            print("No members added yet.\n")
        else:
            name = input("Enter the name of the member to delete: ")
            if name in self.members:
                self.members.remove(name)
                print("Member deleted successfully.")
            else:
                print("Member not found.")

class President:
    @staticmethod
    def display_details():
        print("\nThe President of India is an integral part of the Parliament though he/she is not a member of either House of Parliament. Under the Constitution, the executive power of the Union is vested in the President to be exercised by him/her either directly or through officers subordinates to him/her.\n")
        while True:
            print("1. President")
            print("2. Back to main menu")
            choice = input("Enter your choice: ")
            if choice == '1':
                print("\nThe current President of India is 'Smt. Droupadi Murmu'\n")
            elif choice == '2':
                print("\nReturning to main menu\n")
                break
            else:
                print("\nInvalid choice, please try again")

class RajyaSabha(ParliamentHouse):
    @staticmethod
    def display_details():
        print("\nCouncil of States i.e Rajya Sabha is the Upper House of the Indian Parliament. Rajya Sabha consists of the representatives of the States and the Union Territories and persons nominated by the President of India.\n")
        rs = RajyaSabha()
        while True:
            print("Rajya Sabha")
            print("1. Chairman")
            print("2. Deputy Chairman")
            print("3. Add Member")
            print("4. Display Members")
            print("5. Delete Member")
            print("6. Back to main menu")
            choice = input("Enter your choice: ")
            if choice == '1':
                print("\nThe current chairman of Rajya Sabha 'Shri Jagdeep Dhankhar'\n")
            elif choice == '2':
                print("\nThe current deputy chairman of Rajya Sabha 'Shri Harivansh'\n")
            elif choice == '3':
                rs.add_member()
            elif choice == '4':
                rs.display_members()
            elif choice == '5':
                rs.delete_member()
            elif choice == '6':
                print("\nReturning to main menu\n")
                break
            else:
                print("\nInvalid choice, please try again")

class LokSabha(ParliamentHouse):
    @staticmethod
    def display_details():
        print("\nAs per the provision of Article 79 of Indian Constitution, the House of the People, the Lok Sabha is the lower House of the parliament. Lok Sabha is composed of representatives of the people chosen by direct election on the basis of the adult suffrage\n")
        ls = LokSabha()
        while True:
            print("Lok Sabha")
            print("1. Speaker")
            print("2. Add Member")
            print("3. Display Members")
            print("4. Delete Member")
            print("5. Back to main menu")
            choice = input("Enter your choice: ")
            if choice == '1':
                print("\nThe current speaker of Lok Sabha is 'Shri Om Birla'\n")
            elif choice == '2':
                ls.add_member()
            elif choice == '3':
                ls.display_members()
            elif choice == '4':
                ls.delete_member()
            elif choice == '5':
                print("\nReturning to main menu\n")
                break
            else:
                print("\nInvalid choice, please try again")

def main():
    while True:
        print("Indian Parliament")
        print("1. President of India")
        print("2. Rajya Sabha")
        print("3. Lok Sabha")
        print("4. Exit")
        choice = input("Enter your choice: ")
        if choice == '1':
            President.display_details()
        elif choice == '2':
            RajyaSabha.display_details()
        elif choice == '3':
            LokSabha.display_details()
        elif choice == '4':
            print("Exiting...")
            break
        else:
            print("Invalid choice, please try again")

if __name__ == "__main__":
    main()
