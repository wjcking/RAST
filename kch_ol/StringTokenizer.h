#pragma once
#include "StringBuilder.h"
#include <vector>
using namespace std;
class StringTokenizer
{
private:
	vector<string> container;
	int count;
	bool exist;
	static const vector<string> whitespaces;
	int option;
private:
	void Init(string str, const vector<string>& separator, StringBuilder& builder) // assumtion : separators are sorted by length?, long -> short
	{
		if (separator.empty() || str.empty()) { return; } // if str.empty() == false then _m_str.push_back(str); // ?
														  //
		builder.Clear();
		builder.Append(str.c_str(), str.size());
		int left = 0;
		int right = 0;
		int state = 0;
		this->exist = false;

		for (int i = 0; i < str.size(); ++i) {
			right = i;
			int _select = -1;
			bool pass = false;

			if (1 == option && 0 == state && '\"' == str[i]) {
				if (i == 0) {
					state = 1;
					continue;
				}
				else if (i > 0 && '\\' == str[i - 1]) {
					throw "ERROR for Init on StringTokenizer"; // error!
				}
				else if (i > 0) {
					state = 1;
					continue;
				}
			}
			else if (1 == option && 1 == state && '\"' == str[i]) {
				if ('\\' == str[i - 1]) {
					continue;
				}
				else {
					state = 0;
				}
			}
			else if (1 == option && 1 == state) {
				continue;
			}


			for (int j = 0; j < separator.size(); ++j) {
				for (int k = 0; k < separator[j].size() && i + k < str.size(); ++k) {
					if (str[i + k] == separator[j][k]) {
						pass = true;
					}
					else {
						pass = false;
						break;
					}
				}
				if (pass) { _select = j; break; }
			}

			if (pass) {
				this->exist = true;

				if (right - left >= 0) {
					const char* temp = builder.Divide(right - left);
					if (right - left > 0) {
						container.emplace_back(temp, right - left);
						builder.LeftShift(right - left + 1);
					}
					else {
						builder.LeftShift(1);
					}
				}

				i = i + separator[_select].size() - 1;

				left = i + 1;
				right = left;
			}
			else if (!pass && i == str.size() - 1) {
				if (right - left + 1 > 0) {
					container.emplace_back(builder.Divide(right - left + 1), right - left + 1);
					builder.LeftShift(right - left + 2);
				}
			}
		}
		//cout << "str is " << str <<  " state  is " << state << endl;
	}
public:
	explicit StringTokenizer() : count(0), exist(false), option(0) { }
	explicit StringTokenizer(const string& str, const string& separator, StringBuilder& builder, int option = 0)
		: count(0), exist(false), option(option)
	{
		vector<string> vec; vec.push_back(separator);
		Init(str, vec, builder);
	}
	explicit StringTokenizer(const string& str, const vector<string>& separator, StringBuilder& builder, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(str, separator, builder);
	}
	explicit StringTokenizer(const string& str, StringBuilder& builder, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(str, whitespaces, builder);
	}
	explicit StringTokenizer(string&& str, StringBuilder& builder, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(std::move(str), whitespaces, builder);
	}
	int countTokens()const
	{
		return container.size();
	}
	string nextToken()
	{
		if (hasMoreTokens())
			return container[count++];
		else
			throw "error in nextToken!";
	}
	bool hasMoreTokens()const
	{
		return count < container.size();
	}

	bool isFindExist()const
	{
		return exist;
	}

};
//const vector<string> StringTokenizer::whitespaces = { " ", "\t", "\r", "\n" };

class StringTokenizer2
{
private:
	vector<string> container;
	int count;
	bool exist;
	static const vector<string> whitespaces;
	int option;
private:
	void Init(string str, const vector<string>& separator) // assumtion : separators are sorted by length?, long -> short
	{
		if (separator.empty() || str.empty()) { return; } // if str.empty() == false then _m_str.push_back(str); // ?

		int left = 0;
		int right = 0;
		int state = 0;
		this->exist = false;

		for (int i = 0; i < str.size(); ++i) {
			right = i;
			int _select = -1;
			bool pass = false;

			if (1 == option && 0 == state && '\"' == str[i]) {
				if (i == 0) {
					state = 1;
					continue;
				}
				else if (i > 0 && '\\' == str[i - 1]) {
					throw "ERROR for Init on StringTokenizer"; // error!
				}
				else if (i > 0) {
					state = 1;
					continue;
				}
			}
			else if (1 == option && 1 == state && '\"' == str[i]) {
				if ('\\' == str[i - 1]) {
					continue;
				}
				else {
					state = 0;
				}
			}
			else if (1 == option && 1 == state) {
				continue;
			}


			for (int j = 0; j < separator.size(); ++j) {
				for (int k = 0; k < separator[j].size() && i + k < str.size(); ++k) {
					if (str[i + k] == separator[j][k]) {
						pass = true;
					}
					else {
						pass = false;
						break;
					}
				}
				if (pass) { _select = j; break; }
			}

			if (pass) {
				this->exist = true;

				if (right - 1 - left + 1 > 0) {
					container.push_back(str.substr(left, right - 1 - left + 1));
				}
				i = i + separator[_select].size() - 1;
				left = i + 1;
				right = left;
			}
			else if (!pass && i == str.size() - 1) {
				if (right - left + 1 > 0) {
					container.push_back(str.substr(left, right - left + 1));
				}
			}
		}
		//cout << "str is " << str <<  " state  is " << state << endl;
	}
public:
	explicit StringTokenizer2() : count(0), exist(false), option(0) { }
	explicit StringTokenizer2(const string& str, const string& separator, int option = 0)
		: count(0), exist(false), option(option)
	{
		vector<string> vec; vec.push_back(separator);
		Init(str, vec);
	}
	explicit StringTokenizer2(const string& str, const vector<string>& separator, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(str, separator);
	}
	explicit StringTokenizer2(const string& str, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(str, whitespaces);
	}
	explicit StringTokenizer2(string&& str, int option = 0)
		: count(0), exist(false), option(option)
	{
		Init(std::move(str), whitespaces);
	}
	int countTokens()const
	{
		return container.size();
	}
	string nextToken()
	{
		if (hasMoreTokens())
			return container[count++];
		else
			throw "error in nextToken!";
	}
	bool hasMoreTokens()const
	{
		return count < container.size();
	}

	bool isFindExist()const
	{
		return exist;
	}

};
//const vector<string> StringTokenizer2::whitespaces = { " ", "\t", "\r", "\n" };
