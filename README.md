# Unity Essential Utilities

A collection of lightweight, reusable utility classes and extensions for Unity projects.

This package provides commonly used helpers for working with cameras, coroutines, UI, canvas elements, and transforms. The utilities are designed to be modular and can be used across multiple Unity systems and packages.

---

## Core Functionalities

### Camera Utilities

Provides cached access to the main camera.

```csharp
Camera camera = CameraUtils.Main;
```

The main camera reference is cached to avoid repeatedly searching for `Camera.main`.

The cached reference can also be cleared when necessary:

```csharp
CameraUtils.ClearCache();
```

---

### Coroutine Utilities

Provides cached `WaitForSeconds` instances for commonly reused durations.

```csharp
yield return CoroutineUtils.WaitForSeconds(1f);
```

Repeated calls using the same duration return the cached `WaitForSeconds` instance.

---

### UI Utilities

Provides utilities for checking whether the pointer is currently interacting with a UI element.

```csharp
if (UIUtils.IsPointerOverUI())
{
    return;
}
```

This can be useful when preventing gameplay input while the player is interacting with the UI.

---

### Canvas Utilities

Provides utilities for working with canvas elements.

For example, retrieving the world position of a `RectTransform`:

```csharp
Vector3 position = CanvasUtils.GetWorldPosition(myRectTransform);
```

---

### Transform Extensions

Includes reusable extension methods for Unity's `Transform` component.

#### Delete Children

Deletes all child GameObjects of a transform:

```csharp
transform.DeleteChildren();
```

---

## Installation

Install the package through the Unity Package Manager using your preferred package registry or Git URL.

After installation, import the Utilities namespace:

```csharp
using GoncaloMCOliveira.Utilities;
```

The utility classes can then be accessed directly:

```csharp
CameraUtils.Main;

yield return CoroutineUtils.WaitForSeconds(1f);

if (UIUtils.IsPointerOverUI())
{
    // Handle UI interaction.
}
```

---

## Package Structure

```text
Runtime/
├── Camera/
│   └── CameraUtils.cs
│
├── Coroutines/
│   └── CoroutineUtils.cs
│
├── UI/
│   ├── UIUtils.cs
│   └── CanvasUtils.cs
│
└── Extensions/
    └── TransformExtensions.cs
```

---

## Design Philosophy

The package is designed around small, focused utility classes rather than a single large helper class.

For example:

```text
CameraUtils
CoroutineUtils
UIUtils
CanvasUtils
TransformExtensions
```

This keeps the API organized and makes it easier to expand the package with additional utilities over time.

---

## Requirements

- Unity 6000.3 or later

---

## Notes for Developers

- The utilities are designed to be lightweight and reusable.
- Classes are organized by functionality to avoid creating a large generic helper class.
- Extension methods are provided where they improve readability and usability.
- The package can be used independently or as a dependency for other Unity packages.

## License

See [LICENSE.md](LICENSE.md).
