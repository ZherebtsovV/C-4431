
#  надо сделать консольное приложение Телефонный справочник с внешним хранилищем информации, и чтоб был реализован 
# основной функционал - просмотр, сохранение, импорт, поиск, удаление, изменение данных.

import sqlite3
import os

# Функция для создания базы данных и таблицы
def create_database():
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('CREATE TABLE IF NOT EXISTS contacts (name TEXT, phone TEXT)')
    conn.commit()
    conn.close()

# Функция для просмотра контактов
def view_contacts():
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('SELECT * FROM contacts')
    rows = c.fetchall()
    for row in rows:
        print(f'Name: {row[0]}, Phone: {row[1]}')
    conn.close()

# Функция для сохранения нового контакта
def add_contact(name, phone):
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('INSERT INTO contacts VALUES (?, ?)', (name, phone))
    conn.commit()
    conn.close()

# Функция для импорта контактов из файла
def import_contacts(file_path):
    if os.path.exists(file_path):
        with open(file_path, 'r') as file:
            lines = file.readlines()
            for line in lines:
                parts = line.strip().split(',')
                if len(parts) == 2:  # Проверка на корректный формат строки
                    add_contact(parts[0], parts[1])
                else:
                    print(f'Skipped invalid line: {line}')
        print('Contacts imported successfully.')
    else:
        print('File not found.')

# Функция для поиска контакта по имени или номеру телефона
def search_contact(query):
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('SELECT * FROM contacts WHERE name LIKE ? OR phone LIKE ?', ('%' + query + '%', '%' + query + '%'))
    rows = c.fetchall()
    for row in rows:
        print(f'Name: {row[0]}, Phone: {row[1]}')
    conn.close()

# Функция для удаления контакта
def delete_contact(name):
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('DELETE FROM contacts WHERE name = ?', (name,))
    conn.commit()
    conn.close()
    print('Contact deleted successfully.')

# Функция для изменения данных контакта
def update_contact(name, new_phone):
    conn = sqlite3.connect('tel.db')
    c = conn.cursor()
    c.execute('UPDATE contacts SET phone = ? WHERE name = ?', (new_phone, name))
    conn.commit()
    conn.close()
    print('Contact updated successfully.')

# Основная функция для запуска приложения
def main():
    create_database()

    while True:
        print('\nTelephone Directory Application Menu:')
        print('1. View Contacts')
        print('2. Add Contact')
        print('3. Import Contacts from File')
        print('4. Search Contact')
        print('5. Delete Contact')
        print('6. Update Contact')
        print('7. Exit')

        choice = input('Enter your choice: ')

        if choice == '1':
            view_contacts()
        elif choice == '2':
            name = input('Enter contact name: ')
            phone = input('Enter contact phone: ')
            add_contact(name, phone)
            print('Contact added successfully.')
        elif choice == '3':
            file_path = input('Enter the file path for importing contacts: ')
            import_contacts(file_path)
        elif choice == '4':
            query = input('Enter a name or phone to search: ')
            search_contact(query)
        elif choice == '5':
            name = input('Enter the name of the contact to delete: ')
            delete_contact(name)
        elif choice == '6':
            name = input('Enter the name of the contact to update: ')
            new_phone = input('Enter the new phone number: ')
            update_contact(name, new_phone)
        elif choice == '7':
            break
        else:
            print('Invalid choice. Please try again.')

if __name__ == '__main__':
    main()





















