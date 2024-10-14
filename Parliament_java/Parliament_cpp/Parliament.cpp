#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cctype>

class ParliamentHouse {
private:
    std::vector<std::string> members;

public:
    void addMember() {
        std::string name;
        std::cout << "Enter the name of the member to add: ";
        std::cin >> name;
        if (std::all_of(name.begin(), name.end(), [](char c) { return std::isalpha(c); })) {
            members.push_back(name);
            std::cout << "Member added successfully." << std::endl;
        } else {
            std::cout << "Invalid name. Only alphabetic characters are allowed." << std::endl;
        }
    }

    void displayMembers() const {
        if (members.empty()) {
            std::cout << "No members added yet.\n" << std::endl;
        } else {
            std::cout << "Members:\n" << std::endl;
            for (const auto& member : members) {
                std::cout << member << std::endl;
            }
        }
    }

    void deleteMember() {
        if (members.empty()) {
            std::cout << "No members added yet.\n" << std::endl;
        } else {
            std::string name;
            std::cout << "Enter the name of the member to delete: ";
            std::cin >> name;
            auto it = std::find(members.begin(), members.end(), name);
            if (it != members.end()) {
                members.erase(it);
                std::cout << "Member deleted successfully." << std::endl;
            } else {
                std::cout << "Member not found." << std::endl;
            }
        }
    }
};

class President {
public:
    static void displayDetails() {
        std::cout << "\nThe President of India is an integral part of the Parliament though he/she is not a member of either House of Parliament. Under the Constitution, the executive power of the Union is vested in the President to be exercised by him/her either directly or through officers subordinates to him/her.\n" << std::endl;
        int choice;
        do {
            std::cout << "1. President" << std::endl;
            std::cout << "2. Back to main menu" << std::endl;
            std::cout << "Enter your choice: ";
            std::cin >> choice;
            switch (choice) {
                case 1:
                    std::cout << "\nThe current President of India is 'Smt. Droupadi Murmu'\n" << std::endl;
                    break;
                case 2:
                    std::cout << "\nReturning to main menu\n" << std::endl;
                    break;
                default:
                    std::cout << "\nInvalid choice, please try again" << std::endl;
            }
        } while (choice != 2);
    }
};

class RajyaSabha : public ParliamentHouse {
public:
    static void displayDetails() {
        std::cout << "\nCouncil of States i.e Rajya Sabha is the Upper House of the Indian Parliament. Rajya Sabha consists of the representatives of the States and the Union Territories and persons nominated by the President of India.\n" << std::endl;
        RajyaSabha rs;
        int choice;
        do {
            std::cout << "Rajya Sabha" << std::endl;
            std::cout << "1. Chairman" << std::endl;
            std::cout << "2. Deputy Chairman" << std::endl;
            std::cout << "3. Add Member" << std::endl;
            std::cout << "4. Display Members" << std::endl;
            std::cout << "5. Delete Member" << std::endl;
            std::cout << "6. Back to main menu" << std::endl;
            std::cout << "Enter your choice: ";
            std::cin >> choice;
            switch (choice) {
                case 1:
                    std::cout << "\nThe current chairman of Rajya Sabha 'Shri Jagdeep Dhankhar' \n" << std::endl;
                    break;
                case 2:
                    std::cout << "\nThe current deputy chairman of Rajya Sabha 'Shri Harivansh' \n" << std::endl;
                    break;
                case 3:
                    rs.addMember();
                    break;
                case 4:
                    rs.displayMembers();
                    break;
                case 5:
                    rs.deleteMember();
                    break;
                case 6:
                    std::cout << "\nReturning to main menu\n" << std::endl;
                    break;
                default:
                    std::cout << "\nInvalid choice, please try again" << std::endl;
            }
        } while (choice != 6);
    }
};

class LokSabha : public ParliamentHouse {
public:
    static void displayDetails() {
        std::cout << "\nAs per the provision of Article 79 of Indian Constitution, the House of the People, the Lok Sabha is the lower House of the parliament. Lok Sabha is composed of representatives of the people chosen by direct election on the basis of the adult suffrage\n" << std::endl;
        LokSabha ls;
        int choice;
        do {
            std::cout << "Lok Sabha" << std::endl;
            std::cout << "1. Speaker" << std::endl;
            std::cout << "2. Add Member" << std::endl;
            std::cout << "3. Display Members" << std::endl;
            std::cout << "4. Delete Member" << std::endl;
            std::cout << "5. Back to main menu" << std::endl;
            std::cout << "Enter your choice: ";
            std::cin >> choice;
            switch (choice) {
                case 1:
                    std::cout << "\nThe current speaker of Lok Sabha is 'Shri Om Birla'\n" << std::endl;
                    break;
                case 2:
                    ls.addMember();
                    break;
                case 3:
                    ls.displayMembers();
                    break;
                case 4:
                    ls.deleteMember();
                    break;
                case 5:
                    std::cout << "\nReturning to main menu\n" << std::endl;
                    break;
                default:
                    std::cout << "\nInvalid choice, please try again" << std::endl;
            }
        } while (choice != 5);
    }
};

int main() {
    int choice;
    do {
        std::cout << "Indian Parliament" << std::endl;
        std::cout << "1. President of India" << std::endl;
        std::cout << "2. Rajya Sabha" << std::endl;
        std::cout << "3. Lok Sabha" << std::endl;
        std::cout << "4. Exit" << std::endl;
        std::cout << "Enter your choice: ";
        std::cin >> choice;
        switch (choice) {
            case 1:
                President::displayDetails();
                break;
            case 2:
                RajyaSabha::displayDetails();
                break;
            case 3:
                LokSabha::displayDetails();
                break;
            case 4:
                std::cout << "Exiting..." << std::endl;
                break;
            default:
                std::cout << "Invalid choice, please try again" << std::endl;
        }
    } while (choice != 4);
    return 0;
}
