**Comment Field:**

	A field for additional notes or comments.

Clear Postal Code Field
	
	When the municipality changes, the postal code (PSC) field should be cleared automatically.

Customer Table Association
	
	Connects to the Customer table (fields: ID, Name).


**Lists for Selection:**

Procedure List

	A predefined list of available salon procedures.

Hair Type List

	A predefined list of hair types.

Hair Length List

	A predefined list of hair lengths.

Hair Color List

	A predefined list of hair colors.


**Methods:**

Estimated Product Usage

	A method to estimate the amount of product required based on the combination of procedure, hair type, and hair length.

Inventory Forecasting

	Creates predictions based on current inventory levels and upcoming orders.

Order Basket Assembly

	Compiles a product basket based on customer orders.

**Planned tables**

Order Table Structure:

Fields:

	ID
	CustomerID
	RelativeID
	AppointmentDate
	ProcedureID
	ProductID List
	Discount (Promotion)
	Estimated Price
	Notes
	DateAdded

Product Table Structure:

Fields:

	ID
	EAN (European Article Number)
	Name
	Packaging Size
	Manufacturer
	Product Family
	User Manual (optional, as a comment/note)
	
Inventory Table Structure:
Fields:

	ID
	ProductID
	Purchase Price (excluding VAT)
	VAT Rate
	Purchase Price (including VAT)
	Supplier
	Remaining Stock (units in inventory)

Relatives Table Structure (CustomerRelative):

Fields:

	ID
	CustomerID
	FirstName
	LastName
	Notes
	IsActive (to track if the relative is currently active or inactive)

Relatives Details Table Structure (CustomerDetails):

Fields:

	ID
	CustomerType (Customer or Relative)
	PersonID (either Customer.ID or Relative.ID)
	Hair Length
	Hair Type
	Hair Color
