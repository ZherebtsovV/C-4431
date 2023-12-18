# Импортируем библиотеки
import json
import datetime

# Создаем класс заметки
class Note:
    def __init__(self, ID, title, body, date):
        self.ID = ID
        self.title = title
        self.body = body
        self.date = date

# Функция для сохранения заметок в json файл
def save_notes(notes):
    with open('notes.json', 'w') as file:
        json.dump(notes, file, default=lambda o: o.__dict__)

# Функция для загрузки заметок из json файла
def load_notes():
    try:
        with open('notes.json', 'r') as file:
            notes = json.load(file)
            return [Note(note['ID'], note['title'], note['body'], note['date']) for note in notes]
    except:
        return []

# Функция для вывода списка заметок
def display_notes(notes):
    for note in notes:
        print("ID: ", note.ID)
        print("Дата: ", note.date)
        print("Заголовок: ", note.title)
        print("Тело: ", note.body)
        print()

# Главная функция
def main():
    notes = load_notes()

    while True:
        print("Введите команду:")
        print("add - добавить новую заметку")
        print("edit - редактировать заметку")
        print("read - прочитать заметку")
        print("delete - удалить заметку")
        print("list - вывести список заметок")
        print("exit - выйти из программы")

        command = input()

        if command == "add":
            ID = len(notes) + 1
            title = input("Введите заголовок заметки: ")
            body = input("Введите тело заметки: ")
            date = datetime.datetime.now().strftime("%d-%m-%Y %H:%M:%S")
            notes.append(Note(ID, title, body, date))
            save_notes(notes)
            print("Заметка успешно сохранена")

        elif command == "edit":
            ID = int(input("Введите ID заметки для редактирования: "))
            for note in notes:
                if note.ID == ID:
                    note.title = input("Введите новый заголовок заметки: ")
                    note.body = input("Введите новое тело заметки: ")
                    note.date = datetime.datetime.now().strftime("%d-%m-%Y %H:%M:%S")
                    save_notes(notes)
                    print("Заметка успешно отредактирована")
                    break

        elif command == "read":
            ID = int(input("Введите ID заметки для чтения: "))
            for note in notes:
                if note.ID == ID:
                    print("ID: ", note.ID)
                    print("Дата: ", note.date)
                    print("Заголовок: ", note.title)
                    print("Тело: ", note.body)

        elif command == "delete":
            ID = int(input("Введите ID заметки для удаления: "))
            notes = [note for note in notes if note.ID != ID]
            save_notes(notes)
            print("Заметка успешно удалена")

        elif command == "list":
            display_notes(notes)

        elif command == "exit":
            break

        else:
            print("Некорректная команда")

if __name__ == "__main__":
    main()
